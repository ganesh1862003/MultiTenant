using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using VFS.Common.Configuration;
using VFS.Common.Configuration.Models;

namespace VFS.Common.BaseService.ConnectionFactory
{
    /// <summary>
    /// To create DB connection
    /// </summary>
    public class SqlConnectionFactory : IConnectionFactory
    {
        private readonly IConfigurationManager _configurationManager;

        public SqlConnectionFactory(IConfigurationManager configurationManager)
        {
            _configurationManager = configurationManager;
        }

        /// <summary>
        /// Returns DB connection on basis of DatabaseType (SharedDB or TransactionDB)
        /// </summary>
        /// <param name="context"></param>
        /// <param name="databaseType"></param>
        /// <returns></returns>
        public async Task<IDbConnection> CreateConnectionAsync(AppContext context, DatabaseType databaseType)
        {
            SystemConfiguration configuration;
            switch (databaseType)
            {
                case DatabaseType.SharedDB:
                    configuration = await _configurationManager.GetSystemConfigurationAsync(context, ConfigurationConstants.SHARED_DB_CONFIGURATION_KEY);
                    return new SqlConnection(configuration.Value);
                default://Transaction DB
                    configuration = await _configurationManager.GetSystemConfigurationAsync(context, ConfigurationConstants.TRANSACTION_DB_CONFIGURATION_KEY);
                    return new SqlConnection(configuration.Value);
            }
        }
    }
}

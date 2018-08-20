using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using VFS.Common.Configuration.Models;

namespace VFS.Common.Configuration.Repository
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        private readonly string _configDBConnectionString;

        public ConfigurationRepository(ConfigurationSettings configurationSettings)
        {
            _configDBConnectionString = configurationSettings.ConfigDbConnectionString;
        }

        /// <summary>
        /// This method is used to get ConfigurationValue (DB connection details)
        /// </summary>
        /// <param name="context"></param>
        /// <param name="configurationKey"></param>
        /// <returns>It returns Configuration Value based on enigmacontext and configurationkey</returns>
        public async Task<IList<SystemConfiguration>> GetSystemConfigurationAsync(ApplicationContext context, string configurationKey)
        {
            using (IDbConnection connection = new SqlConnection(_configDBConnectionString))
            {
                connection.Open();

                var param = new
                {
                    configurationKey = configurationKey,
                    MissionID = context?.MissionID,
                    CountryOpsID = context?.CountryOpsID,
                    UnitOpsID = context?.UnitOpsID
                };

                return (await connection.QueryAsync<SystemConfiguration>(ConfigurationSPConstants.GetSystemConfiguration, (object)param, null, null, CommandType.StoredProcedure)).ToList();
            }
        }
    }
}

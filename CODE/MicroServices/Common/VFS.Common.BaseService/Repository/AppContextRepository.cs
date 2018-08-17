using Dapper;
using System.Data;
using System.Threading.Tasks;
using VFS.Common.BaseService.ConnectionFactory;
using VFS.Common.BaseService.Models;
using VFS.Common.Configuration.Models;

namespace VFS.Common.BaseService.Repository
{
    public class AppContextRepository : IAppContextRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public AppContextRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        /// <summary>
        /// Returns the Global App Context 
        /// </summary>
        /// <param name="missionCode"></param>
        /// <param name="countryOpsCode"></param>
        /// <param name="unitOpsCode"></param>
        /// <returns></returns>
        public async Task<AppContext> GetAppContextAsync(string missionCode, string countryOpsCode, string unitOpsCode)
        {
            var context = new AppContext();

            using (IDbConnection connection = await _connectionFactory.CreateConnectionAsync(context, DatabaseType.SharedDB))
            {
                connection.Open();

                var param = new
                {
                    MissionCode = missionCode,
                    CountryOpsCode = countryOpsCode,
                    UnitOpsCode = unitOpsCode
                };

                context = await connection.QueryFirstOrDefaultAsync<AppContext>(BaseSPConstant.usp_GetAppContext
                    , param, null, null, CommandType.StoredProcedure);
            }

            return context;
        }
    }
}

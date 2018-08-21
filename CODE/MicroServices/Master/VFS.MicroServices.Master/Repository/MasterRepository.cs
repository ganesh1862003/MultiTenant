using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using VFS.Common.BaseService.ConnectionFactory;
using VFS.Common.Configuration.Models;
using VFS.MicroServices.Master.Models;

namespace VFS.MicroServices.Master.Repository
{
    public class MasterRepository : IMasterRepository
    {
        private readonly IConnectionFactory _connectionFactory = null;

        /// <summary>
        /// Default class constructor. This accept to pass IConnectionFactory object as input parameter
        /// </summary>
        /// <param name="connectionFactory">Input parameter</param>
        public MasterRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="applicationContext"></param>
        /// <param name="formmetadataContext"></param>
        /// <returns></returns>
        public async Task<List<T>> FetchMasterMetadataAsync<T>(ApplicationContext applicationContext, FormMetadataContext formMetadataContext)
        {
            using (var conn = await _connectionFactory.CreateConnectionAsync(applicationContext, DatabaseType.TransactionDB))
            {
                if (conn.State != ConnectionState.Closed) { conn.Close(); conn.Open();}               

                var parameters = new DynamicParameters();
                parameters.Add("@i_formId", formMetadataContext.FormId, DbType.Int32, ParameterDirection.Input);
                //parameters.Add("@i_fieldCategoryId", formMetadataContext.FormCatId, DbType.Int32, ParameterDirection.Input);
                //parameters.Add("@i_fieldId", formMetadataContext.FormFieldId, DbType.Int32, ParameterDirection.Input);

                var result = await conn.QueryAsync<T>(StoredProcedures.USP_GETMASTERTABLELIST, parameters, commandType: CommandType.StoredProcedure);
                if (result == null)
                    return null;
                else return result.ToList();
            }
        }

        /// <summary>
        /// Generic method to fetch master data
        /// </summary>
        /// <typeparam name="T">Generic class type</typeparam>
        /// <param name="applicationContext">Input parameter</param>
        /// <param name="FormTableMetaData">Input complex parameter</param>
        /// <returns>returns the masters list </returns>
        public async Task<List<T>> FetchMasterDataAsync<T>(ApplicationContext applicationContext, FormTableMetaData formTableMetadata)
        {
            #region Get Master table data based on tablemetadata 

            //Estiblise transaction database connection 
            using (var conn = await _connectionFactory.
                CreateConnectionAsync(applicationContext, DatabaseType.TransactionDB))
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                conn.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@i_TableName", formTableMetadata.TableName, DbType.String, ParameterDirection.Input);
                parameters.Add("@i_TableKey", formTableMetadata.Key, DbType.String, ParameterDirection.Input);
                parameters.Add("@i_TableValue", formTableMetadata.Value, DbType.String, ParameterDirection.Input);

                var result = await conn.QueryAsync<T>(StoredProcedures.USP_GETMASTERS, parameters, commandType: CommandType.StoredProcedure);
                if (result == null)
                    return null;
                else return result.ToList();
            }

            #endregion 
        }
    }
}

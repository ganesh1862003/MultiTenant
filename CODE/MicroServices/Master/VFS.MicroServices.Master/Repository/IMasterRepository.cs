using System.Collections.Generic;
using System.Threading.Tasks;
using VFS.MicroServices.Master.Models;
using VFS.Common.Configuration.Models;

namespace VFS.MicroServices.Master.Repository
{
    public interface IMasterRepository
    {
        /// <summary>
        /// Get Generic Masters table list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="appContext"></param>
        /// <param name="formmetadataContext"></param>
        /// <returns>List of table list</returns>
        Task<List<T>> FetchMasterMetadataAsync<T>(ApplicationContext applicationContext, FormMetadataContext formmetadataContext);

        /// <summary>
        /// Get Generic Masters Data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="appContext"></param>
        /// <param name="formTableMetadata"></param>
        /// <returns></returns>
        Task<List<T>> FetchMasterDataAsync<T>(ApplicationContext applicationContext, FormTableMetaData formTableMetadata);
    }
}

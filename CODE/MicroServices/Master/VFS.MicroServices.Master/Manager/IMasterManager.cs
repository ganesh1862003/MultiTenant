using System.Collections.Generic;
using System.Threading.Tasks;
using VFS.MicroServices.Master.Models;
using VFS.Common.Configuration.Models;

namespace VFS.MicroServices.Master.Manager
{
    public interface IMasterManager
    {
        /// <summary>
        /// Get Generic Masters Data
        /// </summary>
        /// <param name="appContext"></param>
        /// <param name="formMetadataContext"></param>
        /// <returns>IDictionary<string, object></returns>
        Task<IDictionary<string, object>> FetchMasterMetaDataAsync(ApplicationContext applicationContext, FormMetadataContext formMetadataContext);
    }
}

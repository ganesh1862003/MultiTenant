using System.Collections.Generic;
using System.Threading.Tasks;
using VFS.Common.Configuration.Models;
using VFS.MicroServices.Master.Models;
using VFS.MicroServices.Master.Repository;

namespace VFS.MicroServices.Master.Manager
{
    public class MasterManager : IMasterManager
    {
        private IMasterRepository _masterRepository = null;
        public MasterManager(IMasterRepository masterRepository) => _masterRepository = masterRepository;


        public Task<IDictionary<string, object>> FetchMasterMetaDataAsync(ApplicationContext applicationContext, FormMetadataContext formMetadataContext)
        {
            throw new System.NotImplementedException();
        }
    }
}

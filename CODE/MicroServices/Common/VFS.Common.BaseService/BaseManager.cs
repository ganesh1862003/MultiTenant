using VFS.Common.BaseService.Repository;
using VFS.Common.Configuration.Models;

namespace VFS.Common.BaseService
{
    public class BaseManager
    {
        private readonly IAppContextRepository _AppContextRepository;
        public BaseManager(IAppContextRepository AppContextRepository)
        {
            _AppContextRepository = AppContextRepository;
        }

        /// <summary>
        /// Returns the Global App Context 
        /// </summary>
        /// <param name="AppUrl"></param>
        /// <returns>Returns the Global App Context </returns>
        public ApplicationContext BuildAppContext(ApplicationUrl AppUrl)
        {
            return _AppContextRepository.GetAppContextAsync(AppUrl?.MissionCode, AppUrl?.CountryOpsCode, AppUrl?.UnitOpsCode).Result;
        }
    }
}

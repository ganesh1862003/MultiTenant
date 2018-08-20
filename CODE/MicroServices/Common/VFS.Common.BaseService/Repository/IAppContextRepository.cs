using System.Threading.Tasks;
using VFS.Common.Configuration.Models;

namespace VFS.Common.BaseService.Repository
{
    public interface IAppContextRepository
    {
        Task<ApplicationContext> GetAppContextAsync(string missionCode, string countryOpsCode, string unitOpsCode);
    }
}

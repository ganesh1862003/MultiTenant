using System.Threading.Tasks;
using VFS.Common.Configuration.Models;

namespace VFS.Common.Configuration
{
    public interface IConfigurationManager
    {
        Task<SystemConfiguration> GetSystemConfigurationAsync(AppContext context, string configurationKey);
    }
}

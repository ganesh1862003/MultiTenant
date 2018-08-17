using System.Collections.Generic;
using System.Threading.Tasks;
using VFS.Common.Configuration.Models;

namespace VFS.Common.Configuration.Repository
{
    public interface IConfigurationRepository
    {
        Task<IList<SystemConfiguration>> GetSystemConfigurationAsync(AppContext context, string configurationKey);
    }
}

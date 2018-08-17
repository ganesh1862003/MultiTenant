using System.Data;
using System.Threading.Tasks;
using VFS.Common.Configuration.Models;

namespace VFS.Common.BaseService.ConnectionFactory
{
    public interface IConnectionFactory
    {
        Task<IDbConnection> CreateConnectionAsync(AppContext context, DatabaseType databaseType);
    }
}

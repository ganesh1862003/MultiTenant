using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


        public Task<List<T>> FetchMasterMetadataAsync<T>(ApplicationContext applicationContext, FormMetadataContext formmetadataContext)
        {
            throw new NotImplementedException();
        }
    }
}

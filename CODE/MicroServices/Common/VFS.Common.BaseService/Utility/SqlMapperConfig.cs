using Dapper;
using System.Collections.Generic;

namespace VFS.Common.BaseService.Utility
{
    /// <summary>
    /// Mapper for models to map with Data returned from SQL queries
    /// </summary>
    public class SqlMapperConfig
    {
        /// <summary>
        /// Configures the mapper for data returned from SQL queries
        /// </summary>
        public static void Configure()
        {
            SqlMapper.AddTypeHandler(typeof(IDictionary<string, string>), new JsonObjectTypeHandler());
            SqlMapper.AddTypeHandler(typeof(IList<IDictionary<string, string>>), new JsonObjectTypeHandler());
        }
    }
}

using System.Collections.Generic;

namespace VFS.Common.BaseService.Models
{
    public class AppServiceResponse<D>
    {
        public D Data;
        public IList<ValidationError> Error;
    }
}

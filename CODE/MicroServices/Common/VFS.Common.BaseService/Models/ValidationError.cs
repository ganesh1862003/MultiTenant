using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Common.BaseService.Models
{
    public class ValidationError
    {
        public string FieldName { get; set; }
        public List<string> ErrorMessages { get; set; }
        public int? Index { get; set; }
    }
}

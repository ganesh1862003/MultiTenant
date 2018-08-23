using System;
using System.Collections.Generic;

namespace MDM_UI.Models
{
    public partial class Language
    {
        public Language()
        {
            LanguageMap = new HashSet<LanguageMap>();
            MstcountryLangMap = new HashSet<MstcountryLangMap>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public ICollection<LanguageMap> LanguageMap { get; set; }
        public ICollection<MstcountryLangMap> MstcountryLangMap { get; set; }
    }
}

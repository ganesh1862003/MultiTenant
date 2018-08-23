using System;
using System.Collections.Generic;

namespace MDM_UI.Models
{
    public partial class MstcountryLangMap
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }
        public Language Language { get; set; }
    }
}

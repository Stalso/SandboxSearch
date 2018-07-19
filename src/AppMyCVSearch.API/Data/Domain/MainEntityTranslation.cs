using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMyCVSearch.API.Data.Domain
{
    public class MainEntityTranslation : BaseEntity
    {
        public string IndexedSearchableValue { get; set; }
        public string IndexedValue { get; set; }
        public string NotIndexedValue { get; set; }
        public bool IsDefault { get; set; }

        public Guid LanguageId { get; set; }
        public Guid MainEntityId { get; set; }
        public MainEntity MainEntity { get; set; }

    }
}

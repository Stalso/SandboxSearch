using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMyCVSearch.API.Data.Domain
{
    public class ManyToManyEntityTranslation : BaseEntity
    {
        public string IndexedSearchableValue { get; set; }
        public string IndexedValue { get; set; }
        public string NotIndexedValue { get; set; }
        public bool IsDefault { get; set; }

        public Guid LanguageId { get; set; }
        public Guid ManyToManyEntityId { get; set; }
        public ManyToManyEntity ManyToManyEntity { get; set; }
    }
}

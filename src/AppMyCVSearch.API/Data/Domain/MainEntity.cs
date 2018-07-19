using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMyCVSearch.API.Data.Domain
{
    public class MainEntity : BaseEntity
    {
        public string IndexedString { get; set; }
        public string NotIndexedString { get; set; }
        public List<MainEntityTranslation> Translations { get; set; }

        public Guid NumericValueEntityId { get; set; }
        public NumericValueEntity NumericValueEntity { get; set; }

        public Guid StringValueEntityId { get; set; }
        public StringValueEntity StringValueEntity { get; set; }

        public List<JoinEntity> JoinEntities { get; set; }
    }
}

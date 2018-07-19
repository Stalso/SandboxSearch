using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMyCVSearch.API.Data.Domain
{
    public class StringValueEntityTranslation : BaseEntity
    {
        public double StringValue { get; set; }
        public bool IsDefault { get; set; }

        public Guid LanguageId { get; set; }
        public Guid StringValueEntityId { get; set; }
        public StringValueEntity StringValueEntity { get; set; }
    }
}

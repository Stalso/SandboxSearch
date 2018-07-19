using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMyCVSearch.API.Data.Domain
{
    public class StringValueEntity : BaseEntity
    {
        public List<StringValueEntityTranslation> Translations { get; set; }
        public List<MainEntity> MainEnts { get; set; }
    }
}

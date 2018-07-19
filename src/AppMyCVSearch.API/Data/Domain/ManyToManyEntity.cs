using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMyCVSearch.API.Data.Domain
{
    public class ManyToManyEntity : BaseEntity
    {
        public List<ManyToManyEntityTranslation> Translations { get; set; }
        public List<JoinEntity> JoinEntities { get; set; }
    }
}

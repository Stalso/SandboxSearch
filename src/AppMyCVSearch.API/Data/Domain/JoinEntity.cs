using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMyCVSearch.API.Data.Domain
{
    public class JoinEntity
    {
        public Guid MainEntityId { get; set; }
        public MainEntity MainEntity { get; set; }

        public Guid ManyToManyEntityId { get; set; }
        public ManyToManyEntity ManyToManyEntity { get; set; }
    }
}

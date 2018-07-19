using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMyCVSearch.API.Data.Domain
{
    public class NumericValueEntity : BaseEntity
    {
        public double NumericValue { get; set; }
        public List<MainEntity> MainEnts { get; set; }
    }
}

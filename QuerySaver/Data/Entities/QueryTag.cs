using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuerySaver.Data.Entities
{
    public class QueryTag
    {
        public int Id { get; set; }
        public Query Query { get; set; }
        public Tag Tag { get; set; }
    }
}

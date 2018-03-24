using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuerySaver.Data.Entities
{
    public class Query
    {
        public int Id { get; set; }
        [Required]
        public ProjectPart ProjectPart { get; set; }
        [Required]
        public File File { get; set; }

        public ICollection<QueryTag> QueryTags { get; set; }


    }
}

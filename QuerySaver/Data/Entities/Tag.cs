using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuerySaver.Data.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(8)]
        public string Name { get; set; }

        public ICollection<QueryTag> QueryTags { get; set; }



    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuerySaver.Data.Entities
{
    public class ProjectPart
    {
        public int Id { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        public string Name { get; set; }
        public Project Project { get; set; }
        public ICollection<Query> Queries { get; set; }

    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuerySaver.Data.Entities
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        public string Name { get; set; }

        public ICollection<ProjectPart> ProjectParts { get; set; }
    }
}

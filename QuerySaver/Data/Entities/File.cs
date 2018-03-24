using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuerySaver.Data.Entities
{
    public class File
    {
        public int Id { get; set; }
        [Required]
        public string Location { get; set; }
        public decimal FileSize { get; set; }
        [Required]
        public Enums.FileTypeEnum FileType { get; set; }
        public Query Query { get; set; }

    }

    
}

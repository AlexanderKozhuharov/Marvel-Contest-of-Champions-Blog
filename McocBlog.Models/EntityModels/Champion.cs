using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McocBlog.Models.EntityModels
{
    public class Champion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Attack { get; set; }
        [Required]
        public string Class { get; set; }        
        [Required]       
        public DateTime ReleaseDate { get; set; }
    }
}

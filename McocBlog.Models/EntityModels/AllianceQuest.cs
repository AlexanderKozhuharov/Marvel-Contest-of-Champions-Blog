using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McocBlog.Models.EntityModels
{
    public class AllianceQuest
    {
        [Required]
        public string Map { get; set; }
        [Required]
        public decimal WeeklyCostForOneMap { get; set; }
        [Required]
        public decimal WeeklyCostForFiveMaps { get; set; }
        [Required]
        public string MiniBoss { get; set; }
        [Required]
        public string FinalBoss { get; set; }
    }
}

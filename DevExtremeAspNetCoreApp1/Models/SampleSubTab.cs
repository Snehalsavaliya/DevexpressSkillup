using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp1.Models
{
    public class SampleSubTab
    {
        [Required]
        public int? ID { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Contact { get; set; }
    }
}

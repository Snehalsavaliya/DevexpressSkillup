using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp1.Models
{
    public class SampleTab
    {
        [Required]
        public int? ID { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}

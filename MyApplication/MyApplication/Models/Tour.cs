using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    [Table(name: "Tours", Schema = "Tour")]
    public class Tour:Default
    {
        public Tour()
        { 

            Transports = new List<Transport>();

            Healths = new List<Health>();

        }

        public Nullable<decimal> Price { get; set; }

        [MinLength(10)]
        public string Description { get; set; }

        [Required]
        [MaxLength(60)]
        public string ImagePath { get; set; }

        public List<Transport> Transports { get; set; }

        public List<Health> Healths { get; set; }
  

    }
}

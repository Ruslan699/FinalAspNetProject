using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class BronInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public BronEnum BronEnum { get; set; }

        public string ImagePath { get; set; }

        public string ImageText { get; set; }

        public string AboutTourText { get; set; }

        public string AboutTourNumber { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    [Table(name: "BronBilgehs")]
    public class BronBilgeh
    {
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string ImageTitle { get; set; }

        public string AboutTourText { get; set; }

        public string AboutTourNumber { get; set; }
    }
}

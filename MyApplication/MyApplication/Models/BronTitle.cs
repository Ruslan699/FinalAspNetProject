using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    [Table(name:"BronTitles")]
    public class BronTitle
    {
        public int Id { get; set; }
        
        public string TourIncludedText { get; set; }

        public string TourIncludedIcon { get; set; }

    }
}

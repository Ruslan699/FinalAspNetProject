using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class WhyWe:DefaultAbout
    {
        public string ImageTitle { get; set; }

        public int AboutId { get; set; }

        public About About { get; set; }
    }
}

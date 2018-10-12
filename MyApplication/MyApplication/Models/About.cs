using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class About: DefaultAbout
    {
        public string ImageTitle { get; set; }

        public string Text { get; set; }

        public string SubText { get; set; }

        public List<Profile> Profiles { get; set; }

        public List<WhyWe> WhyWes { get; set; }
        
        public List<Compliance> Compliances {get; set;}
        
       
    }
}

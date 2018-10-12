using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class Profile:DefaultAbout
    {

        public string ImageTitle { get; set; }

        public string Text { get; set; }

        public string SubText { get; set; }

        public int AboutId { get; set; }

        public About About { get; set; }


       
    }
}

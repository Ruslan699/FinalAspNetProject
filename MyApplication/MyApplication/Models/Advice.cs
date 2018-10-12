using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class Advice

    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string ImagePath { get; set; }

        public string ImageTitle { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public Service Service { get; set; }

        public int ServiceId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class Festival : SimiliarPages
    {
        public string TourSecondAdditional { get; set; }

        public Event Event { get; set; }

        public int EventId { get; set; }

        public Message Message { get; set; }
    }
}
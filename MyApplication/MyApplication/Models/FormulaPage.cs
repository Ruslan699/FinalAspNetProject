using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class FormulaPage:SimiliarPages
    {
        public string TourSecondAdditional { get; set; }

        public Event Event { get; set; }

        public int EventId { get; set; }

        public Message Message { get; set; }
    }
}

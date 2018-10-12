using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class Azerbaijan
    {
        public int Id { get; set; }

        public string TourImage { get; set; }

        public string TourIcon { get; set; }

        public string TourName { get; set; }

        public string TourTitle { get; set; }

        public string TourTime { get; set; }

        public string TourAction { get; set; }

        public string TourDuration { get; set; }

        public Tour TourId { get; set; }

        public Tour Tour { get; set; }
    }
}
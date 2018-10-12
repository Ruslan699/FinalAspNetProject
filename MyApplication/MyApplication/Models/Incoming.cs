using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class Incoming
    {
        public int Id { get; set; }

        public string TourImage { get; set; }

        public string TourIcon { get; set; }

        public string TourName { get; set; }

        public string TourTitle { get; set; }

        public string TourTime { get; set; }

        public string TourAction { get; set; }

        public Service Service { get; set; }

        public int ServiceId { get; set; }

        public string Duration { get; set; }

        public Tour Tour { get; set; }

        public int TourId { get; set; }

    }
}

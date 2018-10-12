using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class MainPage
    {
        public int Id { get; set; }

        public string TourImage { get; set; }

        public string TourName { get; set; }

        public string TourPrice { get; set; }

        public string TourTime { get; set; }

        public string TourAction { get; set; }

        public string TourDuration { get; set; }

        public Tour TourId { get; set; }

        public Tour Tour { get; set; }
    }
}

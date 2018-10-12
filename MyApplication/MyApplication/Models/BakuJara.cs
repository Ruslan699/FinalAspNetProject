using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class BakuJara
    {
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string ImageText { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Duration { get; set; }

        public string Code { get; set; }

        public string Price { get; set; }

        public string AboutTourText { get; set; }

        public string AboutTourNumber { get; set; }

        public string TourImage { get; set; }

        public string TourName { get; set; }

        public string TourInformation { get; set; }

        public string TourVideo { get; set; }

        public string TourCheckIn { get; set; }

        public string TourText { get; set; }

        public string TourTime { get; set; }

        public string TourAdditional { get; set; }

        public string TourSecondAdditional { get; set; }

        public string Number { get; set; }

        public string SecondNumber { get; set; }

        public string Email { get; set; }

        public string SiteAddress { get; set; }

        public string Address { get; set; }

        public Event Event { get; set; }

        public int EventId { get; set; }

        public Message Message { get; set; }
    }
}

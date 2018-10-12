using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    [Table(name: "Events", Schema = "Event")]
    public class Event
    {
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string ImageTitle { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string EventImage { get; set; }

        public string EventIcon { get; set; }

        public string EventName { get; set; }

        public string EventTitle { get; set; }

        public string EventTime { get; set; }

        public string EventAction { get; set; }

        public string Duration { get; set; }

        public Service Service { get; set; }

        public int ServiceId { get; set; }

        public FormulaPage FormulaPage { get; set; }

        public Festival Festival { get; set; }

        public BakuJara BakuJara { get; set; }

       


    }
}

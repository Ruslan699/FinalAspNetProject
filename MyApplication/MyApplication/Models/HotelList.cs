using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    [Table(name: "HotelLists", Schema = "HotelList")]
    public class HotelList
    {
        public int Id { get; set; }
        
        public string ImagePath { get; set; }

        public string ImageTitle { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Text { get; set; }

        public string Phone { get; set; }

        public string OtherPhone { get; set; }

        public string Email { get; set; }

        public string SiteAddress { get; set; }

        public string Address { get; set; }

        public Service Service { get; set; }

        public int ServiceId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    [Table(name: "GroupTours", Schema ="GroupTour")]
    public class GroupTour
    {
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string ImageText { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public Service Service { get; set; }

        public int ServiceId { get; set; }

        public int UserId { get; set; }

        public Message Message { get; set; }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class Cruiz
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string ImageTitle { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public decimal Price { get; set; }

        public int UserId { get; set; }

        public Service Service { get; set; }

        public int ServiceId { get; set; }

        public Message Message { get; set; }

        //public BronnedInformation BronnedInformation {get;set;}
    }
}

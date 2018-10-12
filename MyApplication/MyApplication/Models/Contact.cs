using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string ImageTitle { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Number { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public Nullable<double> lat { get; set; }

        public Nullable<double> lng { get; set; }

        public Message Message { get; set; }
    }
}

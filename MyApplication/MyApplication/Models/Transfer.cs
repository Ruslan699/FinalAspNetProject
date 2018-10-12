using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    [Table(name: "Transfers", Schema = "Transfer")]
    public class Transfer:Default
    {
        public string ImagePath { get; set; }

        public string ImageTitle { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string Number { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public Nullable <double> lat { get; set; }

        public Nullable <double> lng { get; set; }

        public int UserId { get; set; }

        public Service Service { get; set; }

        public int ServiceId { get; set; }

        public Message Message { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    [Table("OnlinePayments", Schema ="OnlinePayment" )]
    public class OnlinePayment
    {
        public int Id { get; set; }

        public string CardType { get; set; }

        public string CardNumber { get; set; }

        public string ZipCode { get; set; }

        public string ExpirationDate { get; set; }

    }
}

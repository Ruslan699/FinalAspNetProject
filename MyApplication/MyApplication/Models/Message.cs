using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [MinLength(5)]
        [MaxLength(21)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [MinLength(10)]
        public string Number { get; set; }

        [Required]
        public string Messaging { get; set; }
    }
}

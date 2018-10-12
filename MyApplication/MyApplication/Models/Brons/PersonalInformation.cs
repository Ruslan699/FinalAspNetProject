using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.Brons
{
    [Table("PersonalInfos")]
    public class PersonalInformation
    {
        public int Id { get; set; }
 
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(16)]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [MinLength(5)]
        [MaxLength(18)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]        
        public int Number { get; set; }
        
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        public string PassportNumber { get; set; }

        [Required]
        public string Birth { get; set; }

        [Required]
        public int Parent { get; set; }

        public Nullable <int> Child { get; set; }

        public Nullable <int> Baby { get; set; }

        public string Message { get; set; }

       
        public int BronHotelId { get; set; }
        public BronHotel BronHotel { get; set; }

        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.Brons
{
    public class SimpleInformation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [MinLength(3)]
        [MaxLength(11)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        [MinLength(3)]
        [MaxLength(13)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.EmailAddress)]
        [MinLength(5)]
        [MaxLength(18)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.PhoneNumber)]
        public int Number { get; set; }

        public string Message { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Tour { get; set; }

        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateTime { get; set; }


    }
}

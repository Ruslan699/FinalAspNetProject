using MyApplication.Models.Brons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{

    public class BronHotel
    {
            public int Id { get; set; }

            [Required]
            [MinLength(3)]
            [MaxLength(30)]
            public string Name { get; set; }

            public string Price { get; set; }

            public string Description { get; set; }

            public string TypeOf { get; set; }

            public string Value { get; set; }

            public PersonalInformation PersonalInformation { get; set; }
        }
}

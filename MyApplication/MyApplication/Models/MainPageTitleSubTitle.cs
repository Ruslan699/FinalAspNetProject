using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class MainPageTitleSubTitle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string FirstSlide { get; set; }

        public string FirstSlideText { get; set; }

        public string SecondSlide { get; set; }

        public string SecondSlideText { get; set; }

        public string ThirdSlide { get; set; }

        public string ThirdSlideText { get; set; }

        public string FourthSlide { get; set; }

        public string FourthSlideText { get; set; }

        public string Title { get; set; }

    }
}

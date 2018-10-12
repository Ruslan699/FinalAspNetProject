using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class TitleAndSubTitle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public StaticPage StaticPage { get; set; }

        public string ImagePath { get; set; }

        public string ImageText { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public bool _IsService { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class HealthModel
    {
        public List<Health> Healths { get; set; }

        public TitleAndSubTitle TitleAndSubTitles { get; set; }

        public Message Message { get; set; }


    }
}

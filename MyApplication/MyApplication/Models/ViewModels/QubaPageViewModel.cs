using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class QubaPageViewModel
    {
        public List<QubaPageDescription> QubaPageDescriptions { get; set; }

        public QubaPage QubaPage { get; set; }

        public Message Message { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class ShakiPageModel
    {
        public List<ShakiPageDescription> ShakiPageDescriptions { get; set; }

        public ShakiPage ShakiPage { get; set; }

        public Message Message { get; set; }
    }
}

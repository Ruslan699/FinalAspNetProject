using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class LankaranViewModel
    {
        public List<LankaranDescription> LankaranDescriptions { get; set; }

        public LankaranPage LankaranPage { get; set; }

        public Message Message { get; set; }
    }
}

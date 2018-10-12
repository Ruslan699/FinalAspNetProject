using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class GoyGolPageModel
    {
        public List<GoyGolDescription> GoyGolDescriptions { get; set; }

        public GoyGolPage GoyGolPage { get; set; }

        public Message Message { get; set; }
    }
}

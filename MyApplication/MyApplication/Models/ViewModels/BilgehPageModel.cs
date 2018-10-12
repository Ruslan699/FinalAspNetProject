using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class BilgehPageModel
    {
        public List<BilgehDescription> BilgehDescriptions { get; set; }

        public BilgehPage BilgehPage { get; set; }

        public Message Message { get; set; }
    }
}

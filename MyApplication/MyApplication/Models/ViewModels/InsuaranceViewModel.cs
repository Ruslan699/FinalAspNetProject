using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class InsuaranceViewModel
    {
        public List<InsuaranceDescription> InsuaranceDescriptions { get; set; }

        public Insuarance Insuarance { get; set; }

        public Message Message { get; set; }
    }
}

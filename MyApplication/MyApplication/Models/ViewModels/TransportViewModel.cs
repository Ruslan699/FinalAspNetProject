using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class TransportViewModel
    {
        public List<TransportDescription> TransportDescriptions { get; set; }

        public Transport Transport { get; set; }

        public Message Message { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class QabalaViewModel
    {
        public List<QabalaDescriptions> QabalaDescriptions { get; set; }

        public QabalaPage QabalaPage { get; set; }

        public Message Message { get; set; }
    }
}

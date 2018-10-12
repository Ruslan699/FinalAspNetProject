using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class QakhViewModel
    {
        public List<QakhDescriptions> QakhDescriptions { get; set; }

        public QakhPage QakhPage { get; set; }

        public Message Message { get; set; }
    }
}

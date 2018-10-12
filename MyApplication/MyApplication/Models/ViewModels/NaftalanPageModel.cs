using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class NaftalanPageModel
    {
       public List<NaftalanDescription> NaftalanDescriptions { get; set; }
        
        public NaftalanPage NaftalanPage { get; set; }

        public Message Message { get; set; }
    }
}

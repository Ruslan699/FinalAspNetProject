using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class BronLankaranModel
    {
        public BronLankaran BronLankaran { get; set; }

        public List<BronTitle> BronTitle { get; set; }

        public List<BronHotel> BronHotels { get; set; }
    }
}

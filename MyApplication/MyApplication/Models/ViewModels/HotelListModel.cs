using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class HotelListModel
    {
        public List<HotelListDescription> HotelListDescriptions { get; set; }

        public HotelList HotelList { get; set; }

        public Message Message { get; set; }
    }
}

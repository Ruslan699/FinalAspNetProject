using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class Service:DefaultAbout
    {
        public string ImageTitle{ get; set; }

        public bool _IsVisible { get; set; }

        public List<Cruiz> Cruizs { get; set; }

        public List<Transport> Transports { get; set; }

        public List<GroupTour> GroupTours { get; set; }

        public List<Vip> Vips { get; set; }
        
        public List<Incoming> Incomings { get; set; }

        public List<Health> Healths { get; set; }
        
        public List<Event> Events { get; set; }

        public List<Transfer> Transfers { get; set; }
        
        public List<Advice> Advices { get; set; }
        
        public List<Insuarance> Insuarances { get; set; }
        
        public List<Emergency> Emergencies { get; set; }
        
        public List <HotelList> HotelLists { get; set; }
        
    }
}

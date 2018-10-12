using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class EventModel
    {
        public List<Event> Events { get; set; }

        public TitleAndSubTitle TitleAndSubTitle { get; set; }
        public Message Message { get; set; }
    }
}

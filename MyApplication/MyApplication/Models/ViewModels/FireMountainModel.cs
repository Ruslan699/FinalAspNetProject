using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class FireMountainModel
    {
        public List<FireMountainDescription> FireMountainDescriptions { get; set; }

        public FireMountainPage FireMountainPage { get; set; }

        public Message Message { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models.ViewModels
{
    public class VulkanViewModel
    {
        public List<VulkanDescription> VulkanDescriptions { get; set; }

        public VulkanPage VulkanPage { get; set; }

        public Message Message { get; set; }
    }
}

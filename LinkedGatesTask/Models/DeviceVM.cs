using System.ComponentModel.DataAnnotations;

namespace LinkedGatesTask.Models
{
    public class DeviceVM
    {
        [Required]
        public string Name { get; set; }
        public DateTime AcquisitionDate { get; set; } 
        public double memo { get; set; }
        [Required]
        public int CategoryId { get; set; }


    }
}

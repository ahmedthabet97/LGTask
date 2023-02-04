using System.ComponentModel.DataAnnotations;
using TaskDB;

namespace LinkedGatesTask.Models
{
    public class PropertyValuesVM
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int propertyId { get; set; }
        public int DeviceId { get; set; }
        [Required]
        public List<CategoryPropertiesValues> Values { get; set; }
        [Required]
        [Display(Name ="DeviceName")]
        public string DeviceName { get; set; }
        [Display(Name = "DeviceAcquisitionDate")]
        public DateTime DeviceAcquisitionDate { get; set; }
        [Display(Name = "DeviceMemo")]

        public double DeviceMemo { get; set; }
        [Display(Name ="Category Name")]
       public string CategoryName { get; set; }
        
    }
}

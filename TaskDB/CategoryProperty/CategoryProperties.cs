using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDB
{
    public class CategoryPropertiesValues
    {
        //[Key]
        //public int Id { get; set; }
        public int CategoryId { get; set; }
        public int propertyId { get; set; }
        public int DeviceId { get; set; }
        public string Values { get; set; }

        //public virtual ICollection<Device> devices { get; set; }
        //public virtual ICollection<Category> categories { get; set; }
        //public virtual ICollection<Properties> properties { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category category { get; set; }
        [ForeignKey("propertyId")]
        public virtual Properties properties { get; set; }
        [ForeignKey("DeviceId")]
        public virtual Device device { get; set; }


    }
}

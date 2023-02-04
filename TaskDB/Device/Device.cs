using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDB
{
    public class Device
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AcquisitionDate { get; set; }=DateTime.Now;
        public double memo { get; set; }
        [ForeignKey("category")]
        public int CategoryId { get; set; }
      //  public int CategoryPropertiesValuesId { get; set; }
        public virtual Category category { get; set; }
       
        public virtual ICollection<CategoryPropertiesValues> PropertiesValues { get; set; }

    }
}

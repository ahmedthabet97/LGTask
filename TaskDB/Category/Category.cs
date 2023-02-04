using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDB
{
    public class Category
    {
        [Required]
        public string Name { get; set; }
        [Key]
        [Required]
        public int Id { get; set; }
        //public virtual ICollection<Properties> properties { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
       // public int PropertyID { get; set; }
       //[ForeignKey("PropertiesValues")]
       // public int CatId { get; set; }
        //[ForeignKey("CatId")]
        public virtual ICollection<CategoryPropertiesValues> PropertiesValues { get; set; }
        //  public virtual Properties property { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDB
{
    public class Properties
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required] 
        public string Name { get; set; }
        // public virtual  ICollection<Category> categories { get; set;}
         public int CategoryId { get; set; }
         [ForeignKey("CategoryId")]
         public virtual Category category { get; set; }

        // [ForeignKey("PropId")]



    }
}

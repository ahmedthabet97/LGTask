using System.ComponentModel.DataAnnotations;

namespace LinkedGatesTask.Models
{
    public class PropertyVM
    {
        [Required]
        public int PropId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

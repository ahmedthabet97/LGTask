using System.ComponentModel.DataAnnotations;

namespace LinkedGatesTask.Models
{
    public class CategoryVM
    {
        [Required]
        public int CatId { get; set; }
        [Required]
        public string Name { get; set; }

    }
}

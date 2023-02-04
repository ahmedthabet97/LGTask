using LinkedGatesTask.Models;

namespace LinkedGatesTask.Services
{
    public interface ICategoryService
    {
        public IEnumerable<CategoryVM> GetCategories();
    }
}

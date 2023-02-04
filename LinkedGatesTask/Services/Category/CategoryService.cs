using LinkedGatesTask.Models;
using TaskDB;

namespace LinkedGatesTask.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly Context context;
        public CategoryService(Context context)
        {
            this.context = context;
        }

        public IEnumerable<CategoryVM> GetCategories()
        {
            var data = context.Categories.Select(cat=>new CategoryVM{
                Name = cat.Name,
                CatId = cat.Id,
            });
            return data;
        }
    }
}

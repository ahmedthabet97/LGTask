using LinkedGatesTask.Models;
using TaskDB;

namespace LinkedGatesTask.Services
{
    public class PropertyService : IPropertService
    {
        private readonly Context context;
        public PropertyService(Context context)
        {
            this.context = context;
        }
        public IEnumerable<PropertyVM> GetPropertyByCategoryId(int CatId)
        {
            var properties = context.Propertiess.Where(p => p.CategoryId == CatId).Select(s=> new PropertyVM 
            {
                PropId=s.Id,
                Name=s.Name,
            });
            return properties;
        }
    }
}

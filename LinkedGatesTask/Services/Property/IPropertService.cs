using LinkedGatesTask.Models;

namespace LinkedGatesTask.Services
{
    public interface IPropertService
    {
        public IEnumerable<PropertyVM> GetPropertyByCategoryId(int CatId);
    }
}

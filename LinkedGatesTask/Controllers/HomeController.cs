using LinkedGatesTask.Models;
using LinkedGatesTask.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LinkedGatesTask.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ICategoryService categoryService ;
        private readonly IPropertService propertService;
        private readonly IDeviceService deviceService;
        public HomeController(ICategoryService categoryService, IPropertService propertService, IDeviceService deviceService)
        {
            this.categoryService = categoryService;
            this.propertService = propertService;
            this.deviceService = deviceService;
        }

        public IActionResult Index()
        {
            ViewBag.Category = categoryService.GetCategories();
            return View();
        }
        public IActionResult GetProperty(int catId)
        {
            var Properties = propertService.GetPropertyByCategoryId(catId);
          //  TempData["prop"] = Properties;
            return Ok(Properties);
        }
        [HttpPost]
        public IActionResult AddDevice(PropertyValuesVM model)
        {
            //var x = model;
            deviceService.Add(model);
           
            return View();
        }


    }
}
using Microsoft.AspNetCore.Mvc;

namespace AzureRegionMapApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

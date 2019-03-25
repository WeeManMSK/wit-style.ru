using Microsoft.AspNetCore.Mvc;

namespace WitStyle.Web.Controllers
{
    public class AboutController : Controller
    {
        public AboutController()
        {
            ViewData["Title"] = "About";
        }

        public IActionResult Index()
        {            
            return View();
        }
    }
}

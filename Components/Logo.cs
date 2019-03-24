using Microsoft.AspNetCore.Mvc;

namespace WitStyle.Web.Components
{
    public class Logo : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

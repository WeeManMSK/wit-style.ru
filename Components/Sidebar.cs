using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WitStyle.Web.Models;

namespace WitStyle.Web.Components
{
    public class Sidebar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem("Home", "Home", "Index"));
            menuItems.Add(new MenuItem("About", "Home", "About"));

            return View(menuItems);
        }
    }
}
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WitStyle.Common.Global;
using WitStyle.Services;

namespace WitStyle.Web.Components
{
    public class Sidebar : ViewComponent
    {
        private readonly IMenuService _menuService;

        public Sidebar(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menuItems = await _menuService.GetMenuItemsAsync(MenuTypes.Sidebar);

            return View(menuItems);
        }
    }
}
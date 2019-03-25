using System.Threading.Tasks;
using WitStyle.Common.Dto;

namespace WitStyle.Services
{
    public interface IMenuService
    {
        Task<MenuItemDto[]> GetMenuItemsAsync(string menuType);
    }
}

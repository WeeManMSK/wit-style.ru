using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WitStyle.Common.Dto;
using WitStyle.Data;

namespace WitStyle.Services
{
    public class MenuService : IMenuService
    {
        private readonly WitStyleDbContext _dbContext;
        private readonly IMapper _mapper;

        public MenuService(WitStyleDbContext dbContext, IMapper mapper )
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Task<MenuItemDto[]> GetMenuItemsAsync(string menuType)
        {
            return _dbContext.MenuItems.AsNoTracking()
                .Where(x => x.Menu.MenuType == menuType)
                .ProjectTo<MenuItemDto>(_mapper.ConfigurationProvider)
                .ToArrayAsync();
        }
    }
}

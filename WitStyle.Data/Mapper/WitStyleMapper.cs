using AutoMapper;
using WitStyle.Common.Dto;
using WitStyle.Data.Entities;

namespace WitStyle.Data.Mapper
{
    public class WitStyleMapper : Profile
    {
        public WitStyleMapper()
        {
            MapEntities();
        }

        private void MapEntities()
        {
            CreateMap<MenuItem, MenuItemDto>()
                .ForMember(t => t.Children, s => s.MapFrom(x => x.Children));
        }
    }
}

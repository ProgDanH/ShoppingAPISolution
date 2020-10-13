using AutoMapper;
using ShoppingAPI.Domain;
using ShoppingAPI.Models.Catalog;
using ShoppingAPI.Models.Curbside;

namespace ShoppingAPI.Profiles
{
    public class CatalogProfile : Profile
    {
       public CatalogProfile(ConfigurationForMapper _config)
        {
            CreateMap<ShoppingItem, GetCatalogResponseSummaryItem>()
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src =>
                src.Cost * _config.markUp));

            CreateMap<PostCatalogRequest, ShoppingItem>()
			                .ForMember(dest => dest.InInventory, opt => opt.MapFrom(src => true));

            CreateMap<PostCurbsideOrderRequest, CurbsideOrder>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => CurbsideOrderStatus.Pending));
        }
    }
}
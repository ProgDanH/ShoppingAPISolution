using AutoMapper;
using ShoppingAPI.Domain;
using ShoppingAPI.Models.Catalog;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAPI.Profiles
{
    public class CatalogProfile : Profile
    {
        public CatalogProfile(ConfigureForMapper _config)
        {
            CreateMap<ShoppingItem, GetCatalogResponseSummaryItem>()
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => 
                src.Cost * 1.3M));

            CreateMap<PostCatalogRequest, ShoppingItem>()
                .ForMember(dest => dest.InInventory, opt => opt.MapFrom(src => true));
        }
    }
}

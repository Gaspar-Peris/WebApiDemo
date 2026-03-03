using AutoMapper;
using Models;
using Shared;

namespace WebApiDemo.Mapping
{
    public class MappinProfile : Profile
    {
        public MappinProfile() 
        {
            CreateMap<Product, ProductRequestDto>();

            
            CreateMap<Product, ProductResponseDto>();
        }
    }
}

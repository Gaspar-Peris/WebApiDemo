using AutoMapper;
using DataAccess.Models;
using Shared;
using Shared.Dto;

namespace WebApiDemo.Mapping
{
    public class MappinProfile : Profile
    {
        public MappinProfile() 
        {
            CreateMap<User, UserResponseDto>();

            CreateMap<UserResponseDto, User>();

            CreateMap<CategoryRequestDto, Category>();

            CreateMap<ProductRequestDto, Product>();

            CreateMap<Product, ProductRequestDto>();

            CreateMap<Product, ProductResponseDto>();

            CreateMap<Category, CategoryResponseDto>();

        }
    }
}

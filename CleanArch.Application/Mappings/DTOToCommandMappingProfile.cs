using CleanArch.Application.DTOs;
using CleanArch.Application.Products.Commands;
using AutoMapper;

namespace CleanArch.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>();
            CreateMap<ProductDTO, ProductUpdateCommand>();
        }
    }
}

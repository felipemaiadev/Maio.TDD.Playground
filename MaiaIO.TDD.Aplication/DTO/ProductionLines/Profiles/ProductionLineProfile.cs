using AutoMapper;
using MaiaIO.TDD.Aplication.DTO.ProductionLines.Response;
using MaiaIO.TDD.Domain.ProductionLines.Entities;

namespace MaiaIO.TDD.Aplication.DTO.ProductionLines.Profiles
{
    public class ProductionLineProfile : Profile
    {

        public ProductionLineProfile()
        {
            CreateMap<ProductionLineResponse, ProductionLine>().ReverseMap();
            CreateMap<ProductionLineResponse, ProductionLineDTO>().ReverseMap();
            //CreateMap<IEnumerable<ProductionLine>, IEnumerable<ProductionLineResponse>>().ReverseMap();
        }

    }
}

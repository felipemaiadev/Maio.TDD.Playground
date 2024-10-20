using AutoMapper;
using MaiaIO.TDD.API.DTO.Factories.Requests;
using MaiaIO.TDD.API.DTO.Factories.Response;
using MaiaIO.TDD.Domain.Factories.Commands;
using MaiaIO.TDD.Domain.Factories.Entities;

namespace MaiaIO.TDD.API.DTO.Factories.Profiles
{
    public class FactoryProfile : Profile
    {

        public FactoryProfile()
        {
            CreateMap<FactoryGetListRequest, FactoryGetListCommand>();
            CreateMap<FactoryListResponse, Factory>()
                .ForPath(src => src.Lines, dst => dst.MapFrom(x => x.Lines))
                .ReverseMap();

        }
    }
}

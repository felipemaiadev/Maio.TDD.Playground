using AutoMapper;
using MaiaIO.TDD.Aplication.DTO.Factories.Requests;
using MaiaIO.TDD.Aplication.DTO.Factories.Response;
using MaiaIO.TDD.Domain.Factories.Commands;
using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Factories.Repositories.Consultas;

namespace MaiaIO.TDD.API.DTO.Factories.Profiles
{
    public class FactoryProfile : Profile
    {

        public FactoryProfile()
        {

            CreateMap<FactoryResponse, Factory>().ReverseMap();

            CreateMap<FactoryInsertRequest, FactoryInsertCommand>();

            CreateMap<FactoryEditRequest, FactoryEditCommand>();

            CreateMap<FactoryListarConsulta, FactoryListarReponse>();

            //CreateMap<IList<FactoryListarConsulta>, IList<FactoryListarReponse>>();

        }
    }
}

using AutoMapper;
using MaiaIO.TDD.API.DTO.Factories.Requests;
using MaiaIO.TDD.API.DTO.Machines.Response;
using MaiaIO.TDD.Domain.Factories.Commands;
using MaiaIO.TDD.Domain.Machines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Aplication.DTO.Machines
{
    public class MachineDeviceProfile : Profile
    {

        public MachineDeviceProfile() 
        {
            CreateMap<MachineDeviceDTO, MachineDeviceResponse>().ReverseMap();
            CreateMap<MachineDeviceDTO, MachineDevice>().ReverseMap();
        }   
    }
}

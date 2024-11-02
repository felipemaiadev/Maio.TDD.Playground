using AutoMapper;
using MaiaIO.TDD.Aplication.DTO.Devices.Requests;
using MaiaIO.TDD.Aplication.DTO.Devices.Responses;
using MaiaIO.TDD.Domain.Devices.Commands;
using MaiaIO.TDD.Domain.Devices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Aplication.DTO.Devices.Profiles
{
    public class DeviceProfile : Profile
    {

        public DeviceProfile()
        {
            CreateMap<DeviceInsertRequest, DeviceInsertCommand>();
            CreateMap<BaseDevice, DeviceResponse>().ReverseMap();
        }
    }
}

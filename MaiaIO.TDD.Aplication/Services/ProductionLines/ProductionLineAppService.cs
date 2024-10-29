using AutoMapper;
using MaiaIO.TDD.Aplication.DTO.ProductionLines.Response;
using MaiaIO.TDD.Aplication.Services.ProductionLines.Interfaces;
using MaiaIO.TDD.Domain.ProductionLines.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Aplication.Services.ProductionLines
{
    public class ProductionLineAppService(IMapper mapper,
                                        IProductionLineRepository productionLineRepository) : IProductionLineAppService
    {

       
        public async Task<IEnumerable<ProductionLineResponse>> GetAllProductionLinesAsync()
        {
              var result = await productionLineRepository.GetAllProductionLinesAsync();
              return  mapper.Map<IEnumerable<ProductionLineResponse>>(result);
        }
    }
}

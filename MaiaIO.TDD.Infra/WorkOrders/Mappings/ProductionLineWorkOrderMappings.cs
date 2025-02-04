using FluentNHibernate.Mapping;
using MaiaIO.TDD.Domain.ProductionLines.Entities;
using MaiaIO.TDD.Domain.WorkOrders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Infra.WorkOrders.Mappings
{
    public class ProductionLineWorkerOrderMappings : ClassMap<ProductionLineWorkerOrder>
    {
        public ProductionLineWorkerOrderMappings()
        {
             Schema("FTW");
             Table("ProductionLineWorkerOrder");
             Id(x => x.Id).Column("Id");
             Map(x => x.UID).Column("UID");
             Map(x => x.IdProductionLine).Column("IDPRODLINE");
             Map(x => x.IdWorkerOrder).Column("IDWORKERORDER");
             Map(x => x.Status).Column("STATUS");
             Map(x => x.CreateTimeStamp).Column("CREATETIME");

            HasMany(x => x.ProductionLines)
                .Schema("FTW")
                .Table("ProductionLine")
                .KeyColumn("Id");

            HasMany(x => x.WorkOrders)
                .Schema("FTW")
                .Table("WorkerOrder")
                .KeyColumn("Id");
        }
    }
}

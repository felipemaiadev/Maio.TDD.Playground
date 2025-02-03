using FluentNHibernate.Mapping;
using MaiaIO.TDD.Domain.WorkOrders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Infra.WorkOrders.Mappings
{
    public class WorkOrderMappings : ClassMap<WorkOrder>
    {
        public WorkOrderMappings()
        {
            Schema("FTW");
            Table("WorkOrder");
            Id(x => x.Id).Column("Id");
            Map(x => x.UID).Column("UID");
            Map(x => x.OrderCode).Column("OrderCode");
            Map(x => x.OrderName).Column("OrderName");
            Map(x => x.ProductionLine_Id).Column("ProductionLine_Id").Not.Update();

            References(r => r.ProductionLine);
        }
    }
}

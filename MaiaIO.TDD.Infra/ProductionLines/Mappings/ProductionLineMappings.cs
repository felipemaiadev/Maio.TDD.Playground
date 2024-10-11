using FluentNHibernate.Mapping;
using MaiaIO.TDD.Domain.ProductionLines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Infra.ProductionLines.Mappings
{
    public class ProductionLineMappings : ClassMap<ProductionLine>
    {

        public ProductionLineMappings()
        {
            Schema("FTW");
            Table("ProductionLine");
            Id(x => x.Id).GeneratedBy.Guid();
            Map(x => x.CodRef).Column("CodRef");
            Map(x => x.Name).Column("Name");
            Map(x => x.Descriptrion).Column("Description");
            Map(x => x.Factory.Id).Column("Id_Factory");
            Map(x => x.IsActive).Column("IsActive");
            Map(x => x.AssemblyStamp).Column("AssemblyStamp");
            Map(x => x.AssemblyStamp).Column("LastUpdate");
        }
    }
}

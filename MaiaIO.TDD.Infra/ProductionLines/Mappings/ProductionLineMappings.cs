﻿using FluentNHibernate.Mapping;
using MaiaIO.TDD.Domain.ProductionLines.Entities;

namespace MaiaIO.TDD.Infra.ProductionLines.Mappings
{
    public class ProductionLineMappings : ClassMap<ProductionLine>
    {

        public ProductionLineMappings()
        {
            Schema("FTW");
            Table("ProductionLine");
            Id(x => x.Id).Column("Id");
            Map(x => x.UID).Column("UID");
            Map(x => x.Name).Column("Name");
            Map(x => x.Descriptrion).Column("Description");
            Map(x => x.IdFactory).Column("Factory_Id").Not.Update();
            Map(x => x.IsActive).Column("IsActive");
            Map(x => x.AssemblyStamp).Column("AssemblyStamp");
            Map(x => x.LastUpdate).Column("LastUpdate");
            References(r => r.Factory);
            HasMany(r => r.Machines)
                .Schema("FTW")
                .Table("Machine")
                .KeyColumn("ProductionLine_Id")
                .LazyLoad();

        }
    }
}

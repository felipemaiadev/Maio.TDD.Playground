﻿using FluentNHibernate.Mapping;
using MaiaIO.TDD.Domain.Factories.Entities;

namespace MaiaIO.TDD.Infra.Factories.Mappings
{
    public class FactoryMapping : ClassMap<Factory>
    {

        public FactoryMapping()
        {
            Schema("FTW");
            Table("Factory");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.UID).Column("UID");
            Map(x => x.Name).Column("Name");
            Map(x => x.Description).Column("Description");
            Map(x => x.Country).Column("Country");
            Map(x => x.IsActive).Column("IsActive");
            Map(x => x.AssemblyStamp).Column("AssemblyStamp");
            HasMany(x => x.Lines)
                .Schema("FTW")
                .Table("ProductionLine")
                .KeyColumn("Id")
                .Fetch
                .Join();



        }



    }
}

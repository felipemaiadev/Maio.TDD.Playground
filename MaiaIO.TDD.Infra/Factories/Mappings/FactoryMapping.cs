using FluentNHibernate.Mapping;
using MaiaIO.TDD.Domain.Factories.Entities;

namespace MaiaIO.TDD.Infra.Factories.Mappings
{
    public class FactoryMapping : ClassMap<Factory>
    {

        public FactoryMapping()
        {
            Schema("FTW");
            Table("Factory");
            Id(x => x.Id).GeneratedBy.Guid();
            Map(x => x.Name).Column("Name");
            Map(x => x.Description).Column("Description");
            References(x => x.Machines).Not.LazyLoad();

        }

    }
}

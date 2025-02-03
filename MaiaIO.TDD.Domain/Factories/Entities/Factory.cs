using MaiaIO.TDD.Domain.EntityBase;
using MaiaIO.TDD.Domain.ProductionLines.Entities;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace MaiaIO.TDD.Domain.Factories.Entities
{
    public class Factory : Entity
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual string Country { get; protected set; }
        public virtual IList<ProductionLine> Lines { get; protected set; }
        public virtual bool IsActive { get; protected set; }
        public virtual DateTime AssemblyStamp { get; protected set; }


        protected Factory(string name, string description, string country, bool isAtive)
        {

            SetName(name);
            SetDescription(description);
            SetDescription(country);
            SetStatus(isAtive);
            AssemblyStamp = DateTime.UtcNow;
            this.SetLines(new List<ProductionLine>());
        }

        public Factory()
        { }


        public virtual void SetLines(IList<ProductionLine> lines) => this.Lines = lines;
        public virtual Factory SetName(string name)
        {
            if (name == null || name.Length == 0) throw new ArgumentNullException("Name not be Null or Empty");
            Name = name;
            return this;
        }
        public virtual Factory SetDescription(string description)
        {
            if (description == null || description.Length == 0) throw new ArgumentNullException("Description not be Null or Empty");
            Description = description;
            return this;
        }
        public virtual Factory SetCountry(string country)
        {
            if (country == null || country.Length == 0) throw new ArgumentNullException("Coutry not be Null or Empty");
            Country = country;
            return this;
        }
        public virtual Factory SetStatus(bool isAtive) 
        {
            IsActive = isAtive;
            return this;
        }



        public static class FactoryFactory
        {
            public static Factory Create() => new Factory();
            public static Factory Create(string name, string description, string country, bool isAtive)
            {
                var factory = new Factory(); 
                factory.SetName(name)
                       .SetDescription(description)
                       .SetCountry(country)
                       .SetStatus(isAtive);
                return factory;
            }
        }

    }



}


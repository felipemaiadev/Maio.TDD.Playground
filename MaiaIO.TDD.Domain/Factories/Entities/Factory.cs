using MaiaIO.TDD.Domain.EntityBase;
using MaiaIO.TDD.Domain.ProductionLines.Entities;

namespace MaiaIO.TDD.Domain.Factories.Entities
{
    public class Factory : Entity
    {
        public virtual long Id { get;  set; }
        public virtual string Name { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual string Country { get; protected set; }
        public virtual IList<ProductionLine> Lines { get; protected set; }
        public virtual bool IsActive { get; protected set; }
        public virtual DateTime AssemblyStamp { get; protected set; }


        protected Factory(string name, string description, string country, bool isAtive) 
        { 
         
          this.SetLines(new List<ProductionLine>());
        }

        public Factory()
        { }


        public virtual void SetLines(IList<ProductionLine> lines)
        {
            this.Lines = lines;
        }
    }



}


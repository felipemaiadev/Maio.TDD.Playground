﻿using MaiaIO.TDD.Domain.EntityBase;
using MaiaIO.TDD.Domain.ProductionLines.Entities;

namespace MaiaIO.TDD.Domain.Factories.Entities
{
    public class Factory : Entity
    {
        public virtual long CodRef { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual string Coutry { get; protected set; }
        public virtual IEnumerable<ProductionLine> Lines { get; protected set; }
        public virtual bool IsActive { get; protected set; }
        public virtual DateTime AssemblyStamp { get; protected set; }


        public Factory() { }
    }



}


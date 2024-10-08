﻿using MaiaIO.TDD.Domain.EntityBase;

namespace MaiaIO.TDD.Domain.Factories.Entities
{
    public class Factory : Entity
    {
        public virtual long CodRef { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual string Coutry { get; protected set; }
        public virtual int Machines { get; protected set; }
        public virtual bool IsActive { get; protected set; }
        public virtual DateTime AssemblyStamp { get; protected set; }

    }
}


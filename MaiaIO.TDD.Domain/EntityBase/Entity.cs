namespace MaiaIO.TDD.Domain.EntityBase
{
    public abstract class Entity
    {

        public virtual Guid UID { get; set; }

        protected Entity()
        {
            
        }

    }
}

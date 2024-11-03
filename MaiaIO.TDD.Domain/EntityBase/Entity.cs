namespace MaiaIO.TDD.Domain.EntityBase
{
    public abstract class Entity
    {
        public virtual Guid UID { get; protected set; }
        protected Entity()
        {
            SetUID();
        }

        protected void SetUID() => UID = Guid.NewGuid();
    }
}

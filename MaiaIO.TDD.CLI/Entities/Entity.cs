namespace MaiaIO.TDD.CLI.Entities
{
    public abstract class Entity
    {

        public Guid UID { get; set; }

        protected Entity()
        {

            UID = Guid.NewGuid();
        }
    }
}

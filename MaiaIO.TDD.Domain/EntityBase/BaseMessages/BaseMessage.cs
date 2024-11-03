namespace MaiaIO.TDD.Domain.EntityBase.BaseMessages
{
    public abstract class BaseMessage
    {

        public Guid guid { get; protected set; }
        public DateTime timeStamp { get; protected set; }

        protected BaseMessage()
        {
            guid = Guid.NewGuid();
            timeStamp = DateTime.UtcNow;
        }
    }
}

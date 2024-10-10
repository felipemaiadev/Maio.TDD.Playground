using System.ComponentModel.DataAnnotations;

namespace MaiaIO.TDD.API.DataTransfer.Factories.Command
{
    public class FactoryInsertModel
    {
        [Required]
        public virtual string Name { get; protected set; }
        public virtual string Description { get; protected set; }
        [Required]
        public virtual string Coutry { get; protected set; }
        public virtual int Machines { get; protected set; }
        public virtual bool IsActive { get; protected set; }
       

    }
}

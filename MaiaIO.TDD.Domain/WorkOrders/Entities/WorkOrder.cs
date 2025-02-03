using MaiaIO.TDD.Domain.EntityBase;
using MaiaIO.TDD.Domain.ProductionLines.Entities;

namespace MaiaIO.TDD.Domain.WorkOrders.Entities
{
    public class WorkOrder : Entity
    {
        public virtual long Id { get; protected set; }
        public virtual string OrderCode { get; protected set; }
        public virtual string OrderName { get; protected set; }
        public virtual long ProductionLine_Id { get; protected set; }
        public virtual ProductionLine ProductionLine { get; protected set; }

        public WorkOrder()
        {
        }
    }
}

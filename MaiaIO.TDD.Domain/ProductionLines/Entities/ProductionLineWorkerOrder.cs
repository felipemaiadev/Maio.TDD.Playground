using MaiaIO.TDD.Domain.EntityBase;
using MaiaIO.TDD.Domain.WorkOrders.Entities;

namespace MaiaIO.TDD.Domain.ProductionLines.Entities
{
    public class ProductionLineWorkerOrder : Entity
    {
        public virtual long Id { get; protected set; }
        public virtual long IdProductionLine { get; protected set; }
        public virtual long IdWorkerOrder { get; protected set; }
        public virtual bool Status { get; protected set; }
        public virtual DateTime CreateTimeStamp  { get; protected set; }
        public virtual IList<ProductionLine> ProductionLines { get; protected set; } = new List<ProductionLine>();
        public virtual IList<WorkOrder> WorkOrders { get; protected set; } = new List<WorkOrder>();

        protected ProductionLineWorkerOrder()
        { 
        }

        public virtual void SetIdProductionLine(long idprodLine) => IdProductionLine = idprodLine;

        public static class ProductionLineWorkerOrderFactory
        {
            public static ProductionLineWorkerOrder Create() => new ProductionLineWorkerOrder();
        }

    }
}

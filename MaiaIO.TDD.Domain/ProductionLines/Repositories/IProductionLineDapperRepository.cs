namespace MaiaIO.TDD.Domain.ProductionLines.Repositories
{
    public interface IProductionLineDapperRepository
    {
        public Task<int> ReportLinesInvetory();
    }
}

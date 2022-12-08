namespace StockData.Infrastructure.Services
{
    public interface IStockService
    {
        void CreateStockData(List<List<string>> list);
    }
}
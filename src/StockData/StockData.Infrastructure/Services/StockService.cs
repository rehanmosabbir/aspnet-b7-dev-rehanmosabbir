using StockData.Infrastructure.Entities;
using StockData.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockData.Infrastructure.Services
{
    public class StockService : IStockService
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public StockService(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public void CreateStockData(List<List<string>> list)
        {
            Company company = new Company();
            StockPrice stockPrice = new StockPrice();

            foreach(var item in list) 
            {
                for(int i = 0; i < item.Count; i++) 
                {
                    if(i == 1)
                    {
                        company.Id = Guid.NewGuid();
                        company.TradeCode = item[i];
                        _applicationUnitOfWork.Companies.Add(company);
                    }
                    else if(i == 2)
                    {
                        stockPrice.Id= Guid.NewGuid();
                        stockPrice.CompanyId = company.Id;
                        stockPrice.LastTradingPrice = item[i];
                    }
                    else if(i == 3) 
                    {
                        stockPrice.High= item[i];
                    }
                    else if (i == 4)
                    {
                        stockPrice.Low = item[i];
                    }
                    else if (i == 5)
                    {
                        stockPrice.ClosePrice = item[i];
                    }
                    else if (i == 6)
                    {
                        stockPrice.YesterdayClosePrice = item[i];
                    }
                    else if (i == 7)
                    {
                        stockPrice.Change = item[i];
                    }
                    else if (i == 8)
                    {
                        stockPrice.Trade = item[i];
                    }
                    else if (i == 9)
                    {
                        stockPrice.Value = item[i];
                    }
                    else if (i == 10)
                    {
                        stockPrice.Volume = item[i];
                        _applicationUnitOfWork.StockPrices.Add(stockPrice);
                        _applicationUnitOfWork.Save();
                    }
                }
            }

        }
    }
}

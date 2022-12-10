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
            Company company= new Company();
            StockPrice stockPrice = new StockPrice();

            foreach(var item in list) 
            {
                Company? tempdata = new Company();
                for(int i = 0; i < item.Count; i++) 
                {

                    switch(i)
                    {
                            case 1:
                            {
                                tempdata = _applicationUnitOfWork.Companies.Get(x => x.TradeCode == item[i], "StockPrices").FirstOrDefault();

                                if(tempdata == null)
                                {
                                    company.Id = Guid.NewGuid();
                                    company.TradeCode = item[i];
                                    _applicationUnitOfWork.Companies.Add(company);
                                }
                                else
                                {
                                    company.Id = tempdata.Id;
                                }
                                
                                break;
                            }
                            case 2:
                            {
                                stockPrice.Id = Guid.NewGuid();
                                stockPrice.CompanyId = company.Id;
                                stockPrice.LastTradingPrice = item[i];
                                break;
                            }
                            case 3:
                            {
                                stockPrice.High = item[i];
                                break;
                            }
                            case 4:
                            {
                                stockPrice.Low = item[i];
                                break;
                            }
                            case 5:
                            {
                                stockPrice.ClosePrice = item[i];
                                break;
                            }

                            case 6:
                            {
                                stockPrice.YesterdayClosePrice = item[i];
                                break;
                            }
                            case 7:
                            {
                                stockPrice.Change = item[i];
                                break;
                            }
                            case 8:
                            {
                                stockPrice.Trade = item[i];
                                break;
                            }
                            case 9:
                            {
                                stockPrice.Value = item[i];
                                break;
                            }
                            case 10:
                            {
                                stockPrice.Volume = item[i];
                                stockPrice.EntryDate = DateTime.Now;
                                _applicationUnitOfWork.StockPrices.Add(stockPrice);
                                _applicationUnitOfWork.Save();
                                break;
                            }

                    }  
                    
                    
                }
            }

        }
    }
}

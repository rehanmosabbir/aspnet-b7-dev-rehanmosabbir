using HtmlAgilityPack;
using StockData.Infrastructure.Services;

namespace StockData.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IStockService _stockService;
        

        public Worker(ILogger<Worker> logger, IStockService stockService)
        {
            _logger = logger;
            _stockService = stockService;
            
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            List<string> item = new List<string>();
            List<List<string>> items = new List<List<string>>();

            while (!stoppingToken.IsCancellationRequested)
            {
                var url = "https://www.dse.com.bd/latest_share_price_scroll_l.php";
                var web = new HtmlWeb();
                var doc = web.Load(url);

                
                string value;
                var nodeNew = doc.DocumentNode.SelectSingleNode("//span[@class='" + "green" + "']");
                value = nodeNew.InnerText;
                
                var node = doc.DocumentNode.SelectSingleNode("//div[contains(@class, 'table-responsive') and contains(@class, 'inner-scroll')]");
                var table = node.SelectSingleNode("table");
                var trSingle = node.SelectSingleNode("table/tbody/tr");
                var trs = table.SelectNodes("tr");



                foreach (var td in trSingle.SelectNodes("td"))
                {
                    item.Add(td.InnerText.Trim());
                }

                items.Add(item);
                item = new List<string>();

                foreach (var tr in trs)
                {
                    foreach (var td in tr.SelectNodes("td"))
                    {
                        item.Add(td.InnerText.Trim());
                    }

                    items.Add(item);
                    item = new List<string>();
                }

                foreach(var i in items)
                {
                    foreach(var j in i)
                    {
                        Console.Write(j);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                if (value.ToLower() == "open")
                {
                    _stockService.CreateStockData(items);
                }

                //_stockService.CreateStockData(items);

                await Task.Delay(60000, stoppingToken);
            }
        }
    }
}
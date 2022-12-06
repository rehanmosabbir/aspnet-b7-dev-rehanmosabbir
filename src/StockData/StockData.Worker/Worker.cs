using HtmlAgilityPack;

namespace StockData.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
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

                //With XPath
                string value;
                var nodeNew = doc.DocumentNode.SelectSingleNode("//span[@class='" + "green" + "']");
                value = nodeNew.InnerText;
                // Console.WriteLine(value);


                var node = doc.DocumentNode.SelectSingleNode("//div[contains(@class, 'table-responsive') and contains(@class, 'inner-scroll')]");
                var table = node.SelectSingleNode("table");
                var tbodies = table.SelectNodes("tr");

                foreach (var tr in tbodies)
                {
                    foreach (var td in tr.SelectNodes("td"))
                    {
                        item.Add(td.InnerText.Trim());
                        //Console.WriteLine(td.InnerText.Trim());
                    }

                    items.Add(item);
                    item = new List<string>();
                }

                foreach(var i in items)
                {
                    foreach(var j in i)
                    {
                        Console.WriteLine(j);
                    }
                    Console.WriteLine("============");
                }
                await Task.Delay(30000, stoppingToken);
            }
        }
    }
}
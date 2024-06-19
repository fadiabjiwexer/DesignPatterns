using DesignPatterns.Structural_Patterns._1_Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns._1_Adapter.Client
{
    // Client
    public class StockMarketApp
    {
        private IStockDataParser stockDataParser;

        public StockMarketApp(IStockDataParser stockDataParser)
        {
            this.stockDataParser = stockDataParser;
        }

        public void DisplayStockData()
        {
            // The client expects JSON data format for parsing
            string jsonData = ""; // In real scenario, this would be the JSON data to be parsed.
            stockDataParser.ParseData(jsonData);
        }
    }
}

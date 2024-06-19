using DesignPatterns.Structural_Patterns._1_Adapter.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Structural_Patterns._1_Adapter.Implementations
{
    // Adapter
    public class StockDataAdapter : IStockDataParser
    {
        private XmlStockData xmlStockData;

        public StockDataAdapter(XmlStockData xmlStockData)
        {
            this.xmlStockData = xmlStockData;
        }

        public void ParseData(string jsonData)
        {
            string xmlData = xmlStockData.GetStockDataXml();
            XDocument doc = XDocument.Parse(xmlData);
            string json = JsonConvert.SerializeXNode(doc);

            // Assuming ParseData method should handle JSON data
            Console.WriteLine("Parsing JSON data: " + json);
        }
    }

    // Adaptee
    public class XmlStockData
    {
        public string GetStockDataXml()
        {
            // Returns stock data in XML format
            return "<stocks><stock><symbol>AAPL</symbol><price>150</price></stock></stocks>";
        }
    }
}

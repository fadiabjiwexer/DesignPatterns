using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns._1_Adapter.Interfaces
{
    // Target interface
    public interface IStockDataParser
    {
        void ParseData(string jsonData);
    }
}

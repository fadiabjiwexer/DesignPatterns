using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.State.Right.Interface;

namespace DesignPatterns.State.Right.Tools
{
    public class EraserTool : Tool
    {
        public void mousDown()
        {
            Console.WriteLine("Eraser tool");
        }

        public void mousUp()
        {
            Console.WriteLine("Eraser tool");
        }
    }
}

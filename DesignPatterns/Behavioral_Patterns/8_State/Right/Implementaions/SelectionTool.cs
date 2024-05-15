using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavioral_Patterns.State.Right.Interface;

namespace DesignPatterns.Behavioral_Patterns.State.Right.Implementaions
{
    public class SelectionTool : Tool
    {
        public void mousDown()
        {
            Console.WriteLine("Seletion icon");
        }

        public void mousUp()
        {
            Console.WriteLine("Seletion icon");
        }
    }
}

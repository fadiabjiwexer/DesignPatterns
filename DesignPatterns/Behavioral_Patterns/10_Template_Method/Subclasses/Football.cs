using DesignPatterns.Behavioral_Patterns._10_Template_Method.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._10_Template_Method.Subclasses
{
    public class Football : Game
    {
        protected override void Initialize()
        {
            Console.WriteLine("Football Game Initialized! Start playing.");
        }

        protected override void StartPlay()
        {
            Console.WriteLine("Football Game Started. Enjoy the game!");
        }

        protected override void EndPlay()
        {
            Console.WriteLine("Football Game Finished!");
        }
    }
}

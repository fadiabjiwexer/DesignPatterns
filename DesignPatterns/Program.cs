using DesignPatterns.Behavioral_Patterns.State.Wrong;
using DesignPatterns.State.Right;
using DesignPatterns.State.Right.Tools;
using System.Diagnostics;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //State Pattern right using
            //Canvas canvas = new Canvas();
            //canvas.SetCurrentTool(new SelectionTool());
            //canvas.mouseDown();
            //canvas.mouseUp();


            //State Pattern wrong using
            StopWatch stopwatch = new StopWatch();
            stopwatch.Click();
            stopwatch.Click();
            



        }
    }
}

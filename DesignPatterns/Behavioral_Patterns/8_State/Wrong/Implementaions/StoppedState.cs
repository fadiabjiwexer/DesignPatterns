using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavioral_Patterns.State.Wrong;

namespace DesignPatterns.Behavioral_Patterns.State.Wrong.Implementaions
{
    public class StoppedState : Interfaces.State
    {
        private StopWatch stopwatch;
        public StoppedState(StopWatch stopwatch)
        {
            this.stopwatch = stopwatch;
        }
        public void Click()
        {
            stopwatch.setCurrentState(new RunningState(stopwatch));

            Console.WriteLine("Stooped");
        }
    }
}

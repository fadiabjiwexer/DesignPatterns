using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.State.Wrong.Interfaces;

namespace DesignPatterns.State.Wrong.Implementaions
{
    public class RunningState : DesignPatterns.State.Wrong.Interfaces.State
    {
        private StopWatch stopwatch;
        public RunningState(StopWatch stopwatch)
        {
            this.stopwatch = stopwatch;
        }
        public void Click()
        {
            stopwatch.setCurrentState(new RunningState(stopwatch));
            Console.WriteLine("Running");
        }
    }
}

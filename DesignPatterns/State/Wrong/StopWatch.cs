using DesignPatterns.State.Wrong.Implementaions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.Wrong
{
    // This Example about abusing the state patterns and make the thinks more complicated
    public class StopWatch
    {
        //public bool isRunning;
        //public void Click()
        //{
        //    if(isRunning)
        //    {
        //        isRunning = false;
        //        Console.WriteLine("Stopped");
        //    }else
        //    {
        //        isRunning = true;
        //        Console.WriteLine("Running");
        //    }
        //}
        // Developer tried to refactor this method by implement the state pattern here

        private DesignPatterns.State.Wrong.Interfaces.State currentState;

        public StopWatch()
        {
            currentState = new StoppedState(this);
        }

        public DesignPatterns.State.Wrong.Interfaces.State getCurrentState()
        {
            return currentState;
        }

        public void setCurrentState(DesignPatterns.State.Wrong.Interfaces.State state)
        {
            this.currentState = state;
        }


        public void Click()
        {
            currentState.Click();
        }

    }
}

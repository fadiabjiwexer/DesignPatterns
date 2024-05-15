using DesignPatterns.Behavioral_Patterns.State.Wrong.Implementaions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.State.Wrong
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

        private Interfaces.State currentState;

        public StopWatch()
        {
            currentState = new StoppedState(this);
        }

        public Interfaces.State getCurrentState()
        {
            return currentState;
        }

        public void setCurrentState(Interfaces.State state)
        {
            currentState = state;
        }


        public void Click()
        {
            currentState.Click();
        }

    }
}

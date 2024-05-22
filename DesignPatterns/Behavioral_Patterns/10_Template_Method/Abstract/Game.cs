using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._10_Template_Method.Abstract
{
    public abstract class Game
    {
        // Template method
        public void Play()
        {
            Initialize();
            StartPlay();
            EndPlay();
        }

        // Primitive operations (steps to be implemented by subclasses)
        protected abstract void Initialize();
        protected abstract void StartPlay();
        protected abstract void EndPlay();
    }
}

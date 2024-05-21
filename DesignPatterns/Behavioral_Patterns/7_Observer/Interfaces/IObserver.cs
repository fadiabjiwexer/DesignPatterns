﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._7_Observer.Interfaces
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}

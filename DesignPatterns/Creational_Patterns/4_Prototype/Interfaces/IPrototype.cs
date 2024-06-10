using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns._4_Prototype
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}

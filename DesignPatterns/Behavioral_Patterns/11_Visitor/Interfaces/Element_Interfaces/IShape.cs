using DesignPatterns.Behavioral_Patterns._11_Visitor.Interfaces.Visitor_interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._11_Visitor.Element_Interfaces
{
    // Element interface
    interface IShape
    {
        void Accept(IVisitor visitor);
    }
}

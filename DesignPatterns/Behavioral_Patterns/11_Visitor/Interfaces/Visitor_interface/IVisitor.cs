using DesignPatterns.Behavioral_Patterns._11_Visitor.Implementations.Concrete_elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._11_Visitor.Interfaces.Visitor_interface
{
    // Visitor interface
    public interface IVisitor
    {
        void VisitCircle(Circle circle);
        void VisitRectangle(Rectangle rectangle);
    }
}

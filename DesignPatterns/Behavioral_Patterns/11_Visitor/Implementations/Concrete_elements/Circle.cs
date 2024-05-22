using DesignPatterns.Behavioral_Patterns._11_Visitor.Element_Interfaces;
using DesignPatterns.Behavioral_Patterns._11_Visitor.Interfaces.Visitor_interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._11_Visitor.Implementations.Concrete_elements
{
    // Concrete elements
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCircle(this);
        }
    }
}

using DesignPatterns.Behavioral_Patterns._11_Visitor.Implementations.Concrete_elements;
using DesignPatterns.Behavioral_Patterns._11_Visitor.Interfaces.Visitor_interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns._11_Visitor.Implementations.Concrete_visitors
{
    // Concrete visitors
    public class AreaVisitor : IVisitor
    {
        public void VisitCircle(Circle circle)
        {
            double area = Math.PI * Math.Pow(circle.Radius, 2);
            Console.WriteLine($"Area of Circle: {area}");
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            double area = rectangle.Width * rectangle.Height;
            Console.WriteLine($"Area of Rectangle: {area}");
        }
    }
}

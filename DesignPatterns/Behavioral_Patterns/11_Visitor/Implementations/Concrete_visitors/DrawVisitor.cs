using DesignPatterns.Behavioral_Patterns._11_Visitor.Implementations.Concrete_elements;
using DesignPatterns.Behavioral_Patterns._11_Visitor.Interfaces.Visitor_interface;

namespace DesignPatterns.Behavioral_Patterns._11_Visitor.Implementations.Concrete_visitors
{
    public class DrawVisitor : IVisitor
    {
        public void VisitCircle(Circle circle)
        {
            Console.WriteLine($"Drawing Circle with radius {circle.Radius}");
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            Console.WriteLine($"Drawing Rectangle with width {rectangle.Width} and height {rectangle.Height}");
        }
    }
}

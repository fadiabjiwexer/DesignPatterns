using DesignPatterns.Behavioral_Patterns._11_Visitor.Element_Interfaces;
using DesignPatterns.Behavioral_Patterns._11_Visitor.Interfaces.Visitor_interface;

namespace DesignPatterns.Behavioral_Patterns._11_Visitor.Implementations.Concrete_elements
{
    public class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitRectangle(this);
        }
    }
}

namespace DesignPatterns.Structural_Patterns._2_Bridge.Implementor
{
    // RefinedAbstractionA
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.Write("Drawing Circle. ");
            color.ApplyColor();
        }
    }
}

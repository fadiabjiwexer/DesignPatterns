namespace DesignPatterns.Structural_Patterns._2_Bridge.Implementor
{
    // RefinedAbstractionB
    public class Square : Shape
    {
        public Square(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.Write("Drawing Square. ");
            color.ApplyColor();
        }
    }
}

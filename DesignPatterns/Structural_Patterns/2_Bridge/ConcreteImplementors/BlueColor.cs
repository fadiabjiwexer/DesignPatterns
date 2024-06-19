namespace DesignPatterns.Structural_Patterns._2_Bridge.Implementor
{
    // ConcreteImplementorB
    public class BlueColor : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Applying blue color.");
        }
    }
}

namespace DesignPatterns.Structural_Patterns._2_Bridge.Implementor
{
    // ConcreteImplementorA
    public class RedColor : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Applying red color.");
        }
    }
}

using DesignPatterns.Behavioral_Patterns._10_Template_Method.Abstract;

namespace DesignPatterns.Behavioral_Patterns._10_Template_Method.Subclasses
{
    public class Cricket : Game
    {
        protected override void Initialize()
        {
            Console.WriteLine("Cricket Game Initialized! Start playing.");
        }

        protected override void StartPlay()
        {
            Console.WriteLine("Cricket Game Started. Enjoy the game!");
        }

        protected override void EndPlay()
        {
            Console.WriteLine("Cricket Game Finished!");
        }
    }
}

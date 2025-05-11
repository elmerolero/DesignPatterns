using SimUDuck.Interfaces;

namespace SimUDuck.Classes
{
    public class Squeak : IQuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("Squeak");
        }
    }
}

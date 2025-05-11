using SimUDuck.Interfaces;

namespace SimUDuck.Classes
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}

namespace SimUDuck.Classes
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _QuackBehavior = new Quack();
            _FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.Write("I'm a real Mallard duck");
        }
    }
}

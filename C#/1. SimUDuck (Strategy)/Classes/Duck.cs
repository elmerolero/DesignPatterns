using SimUDuck.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Classes
{
    public abstract class Duck
    {
        protected IFlyBehavior _FlyBehavior { get; set; }
        protected IQuackBehavior _QuackBehavior { get; set; }

        public Duck()
        {
        
        }

        public abstract void Display();

        public void PerformFly()
        {
            _FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _QuackBehavior.Quacking();
        }


        public void Swim()
        {
            Console.WriteLine("All ducks float, evan decoys!");
        }
    }
}

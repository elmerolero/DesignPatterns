using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Classes
{
    public abstract class Pizza
    {
        protected string _Name;
        protected string _Dough;
        protected string _Sauce;
        protected List<string> _Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + _Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            foreach (string topping in _Toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutos at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string Name
        {
            get { return _Name; }
        }
    }
}

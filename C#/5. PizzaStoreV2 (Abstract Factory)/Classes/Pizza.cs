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
        protected Dough _Dough { get; set; }
        protected Sauce _Sauce { get; set; }
        protected Veggies[] _Veggies { get; set; }
        protected Cheese _Cheese { get; set; }
        protected Pepperoni _Pepperoni { get; set; }
        protected Clams _Clams { get; set; }

        public abstract void Prepare();

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
            set { _Name = value; }
            get { return _Name; }
        }
    }
}

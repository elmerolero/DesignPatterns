using PizzaStore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public Veggies[] CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clams CreateClams();
    }
}

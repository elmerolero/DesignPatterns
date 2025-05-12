using PizzaStore.Classes.Chicago_Pizza_Store.Ingredients;
using PizzaStore.Classes.New_York_Pizza_Store.Ingredients;
using PizzaStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Classes
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Veggies[] CreateVeggies()
        {
            return [new EggPlant(), new Spinach(), new BlackOlives()];
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }
    }
}

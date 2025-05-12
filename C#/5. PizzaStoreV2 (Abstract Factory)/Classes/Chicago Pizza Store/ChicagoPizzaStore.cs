using PizzaStore.Classes.New_York_Pizza_Store;
using PizzaStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Classes.Chicago_Pizza_Store
{
    public class ChicagoPizzaStore: PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientsFactory = new ChicagoPizzaIngredientFactory();

            switch (item)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientsFactory);
                    pizza.Name = "Chicago Style Cheese Pizza";
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientsFactory);
                    pizza.Name = "Chicago Style Veggie Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientsFactory);
                    pizza.Name = "Chicago Style Clams Pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientsFactory);
                    pizza.Name = "Chicago Style Pepperoni Pizza";
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }
    }
}

using PizzaStore.Classes.New_York_Pizza_Store;
using PizzaStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Classes
{
    public class NYPizzaStore: PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientsFactory = new NYPizzaIngredientFactory();

            switch (item)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientsFactory);
                    pizza.Name = "New York Style Cheese Pizza";
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientsFactory);
                    pizza.Name = "New York Style Veggie Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientsFactory);
                    pizza.Name = "New York Style Clams Pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientsFactory);
                    pizza.Name = "New York Style Pepperoni Pizza";
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }
    }
}

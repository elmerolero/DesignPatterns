using PizzaStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Classes
{
    public class NYStyleCheesePizza: CheesePizza
    {
        public NYStyleCheesePizza(): base(new NYPizzaIngredientFactory())
        {
            _Name = "NY Style Sauce and Cheese Pizza";
            _Toppings.Add("Grated Reggiano Cheese");
        }
    }
}

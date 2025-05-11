using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Classes
{
    public class NYStyleCheesePizza: Pizza
    {
        public NYStyleCheesePizza()
        {
            _Name = "NY Style Sauce and Cheese Pizza";
            _Dough = "Thin Crust Dough";
            _Sauce = "Marinara Sauce";

            _Toppings.Add("Grated Reggiano Cheese");
        }
    }
}

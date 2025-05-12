using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Classes.New_York_Pizza_Store
{
    class NYStyleClamPizza: ClamPizza
    {
        public NYStyleClamPizza(): base( new NYPizzaIngredientFactory() )
        {
            _Name = "NY Style Clam Pizza";
            _Toppings.Add("Grated Reggiano Cheese");
        }
    }
}

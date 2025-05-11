using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Classes.Chicago_Pizza_Store
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            _Name = "Chicago Style Deep Dish Cheeese Pizza";
            _Dough = "Extra Thick Crust Dough";
            _Sauce = "Plum Tomato Sauce";

            _Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

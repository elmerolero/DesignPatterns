using PizzaStore.Classes.New_York_Pizza_Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Classes.California_Pizza_Store
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            switch (item)
            {
                case "cheese":
                    return new CaliforniaStyleCheesePizza();
                case "veggie":
                    return new CaliforniaStyleVeggiePizza();
                case "clam":
                    return new CaliforniaStyleClamPizza();
                case "pepperoni":
                    return new CaliforniaStylePepperoniPizza();
                default:
                    return null;
            }
        }
    }
}

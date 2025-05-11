using PizzaStore.Classes.New_York_Pizza_Store;
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
            switch (item)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                case "veggie":
                    return new NYStyleVeggiePizza();
                case "clam":
                    return new NYStyleClamPizza();
                case "pepperoni":
                    return new NYStylePepperoniPizza();
                default:
                    return null;
            }
        }
    }
}

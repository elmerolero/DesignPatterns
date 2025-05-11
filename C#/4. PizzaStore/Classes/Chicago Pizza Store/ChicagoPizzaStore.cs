using PizzaStore.Classes.New_York_Pizza_Store;
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
            switch (item)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                case "veggie":
                    return new ChicagoStyleVeggiePizza();
                case "clam":
                    return new ChicagoStyleClamPizza();
                case "pepperoni":
                    return new ChicagoStylePepperoniPizza();
                default:
                    return null;
            }
        }
    }
}


using PizzaStore.Classes;
using PizzaStore.Classes.Chicago_Pizza_Store;

PizzaStore.Classes.PizzaStore nyStore = new NYPizzaStore();
PizzaStore.Classes.PizzaStore chicagoStore = new ChicagoPizzaStore();

Pizza pizza = nyStore.OrderPizza("cheese");
Console.WriteLine("Ehtan ordered a " + pizza.Name);

pizza = chicagoStore.OrderPizza("cheese");
Console.WriteLine("Joel ordered a " + pizza.Name);


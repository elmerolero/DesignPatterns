using PizzaStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Classes
{
    public class CheesePizza : Pizza
    {
        IPizzaIngredientFactory _IngredientsFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _IngredientsFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + _Name);
            _Dough = _IngredientsFactory.CreateDough();
            _Sauce = _IngredientsFactory.CreateSauce();
            _Cheese = _IngredientsFactory.CreateCheese();
        }
    }
}

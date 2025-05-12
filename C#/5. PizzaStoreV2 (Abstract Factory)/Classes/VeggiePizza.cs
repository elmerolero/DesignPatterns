using PizzaStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Classes
{
    public class VeggiePizza : Pizza
    {
        IPizzaIngredientFactory _IngredientFactory;
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _IngredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + _Name);
            _Dough = _IngredientFactory.CreateDough();
            _Sauce = _IngredientFactory.CreateSauce();
            _Cheese = _IngredientFactory.CreateCheese();
            _Veggies = _IngredientFactory.CreateVeggies();
        }
    }
}

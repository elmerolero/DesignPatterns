using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz.Classes
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage _Beverage { get; set; }

        protected CondimentDecorator(Beverage beverage)
        {
            _Beverage = beverage;
        }

        public override abstract string GetDescription();
    }
}

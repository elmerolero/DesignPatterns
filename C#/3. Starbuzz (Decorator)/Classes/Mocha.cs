using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz.Classes
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage): base(beverage) { }

        public override string GetDescription()
        {
            return _Beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            switch (_Size)
            {
                case Size.TALL:
                    return _Beverage.Cost() + 0.20;
                case Size.GRANDE:
                    return _Beverage.Cost() + 0.23;
                case Size.VENTI:
                    return _Beverage.Cost() + 0.25;
                default:
                    return _Beverage.Cost() + 0.20;
            }
        }
    }
}

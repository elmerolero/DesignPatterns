using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz.Classes
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage ): base(beverage) { }

        public override string GetDescription()
        {
            return _Beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            switch (_Size)
            {
                case Size.TALL:
                    return _Beverage.Cost() + 0.15;
                case Size.GRANDE:
                    return _Beverage.Cost() + 0.20;
                case Size.VENTI:
                    return _Beverage.Cost() + 0.25;
                default:
                    return _Beverage.Cost() + 0.15;
            }
        }
    }
}

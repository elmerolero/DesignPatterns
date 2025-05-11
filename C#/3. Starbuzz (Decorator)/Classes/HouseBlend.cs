using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz.Classes
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            switch (_Size)
            {
                case Size.TALL:
                    return 0.89;
                case Size.GRANDE:
                    return 1.09;
                case Size.VENTI:
                    return 1.19;
                default:
                    return 1.0f;
            }
        }
    }
}

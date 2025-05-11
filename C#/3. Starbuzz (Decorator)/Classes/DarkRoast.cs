using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz.Classes
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _Description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            switch (_Size)
            {
                case Size.TALL:
                    return 1.0f;
                case Size.GRANDE:
                    return 1.20f;
                case Size.VENTI:
                    return 1.50;
                default:
                    return 1.0f;
            }
        }
    }
}

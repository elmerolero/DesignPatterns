using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz.Classes
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _Description = "Espresso";
        }

        public override double Cost()
        {
            switch (_Size)
            {
                case Size.TALL:
                    return 1.99f;
                case Size.GRANDE:
                    return 2.49f;
                case Size.VENTI:
                    return 2.89;
                default:
                    return 1.99f;
            }
        }
    }
}

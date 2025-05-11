using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz.Classes
{
    public abstract class Beverage
    {  
        public enum Size { TALL, GRANDE, VENTI };

        protected string _Description { get; set; } = "Unknown Beverage";
        protected Size _Size = Size.TALL;
        public Size Sizes
        {
            get 
            { 
                return _Size;
            }

            set
            {
                _Size = value;
            }
        }

        public virtual string GetDescription()
        {
            return _Description;
        }

        public abstract double Cost();
        
    }
}

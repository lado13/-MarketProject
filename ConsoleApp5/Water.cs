using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal class Water : Beverage
    {
        public bool IsMineralWater { get; set; }
        private string _mineral;
        public Water()
        {
            base.IsAlcohol = false;

        }
        public override string ToString()
        {
            _mineral = IsMineralWater ? "Yes" : "No";
            return base.ToString()+ $" Mineral {_mineral}";
        }
    }
}

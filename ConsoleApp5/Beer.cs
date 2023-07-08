using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal class Beer : Beverage
    {
        public string BeerType { get; set; }

        public Beer()
        {
            IsAlcohol = true;
        }
        public override string ToString()
        {
            return base.ToString()+$" Beer Type {BeerType}";
        }
    }
}

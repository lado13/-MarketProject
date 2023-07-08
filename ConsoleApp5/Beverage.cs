using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal class Beverage : Market
    {
        public double Size { get; set; }
        protected bool IsAlcohol { get; set; }
        private string _alcoholType;
        public override string ToString()
        {
            _alcoholType = IsAlcohol ? "Yes" : "No";
            return base.ToString()+$" Alcohol : {_alcoholType} Size {Size} .ml";
        }
    }
}

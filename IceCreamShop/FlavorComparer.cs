using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class FlavorComparer : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            if (x.Allergens.Count > y.Allergens.Count)
            {
                return 1;
            }
            else if (x.Allergens.Count < y.Allergens.Count)
            {
                return -1;
            }
            else
            {
                return 0;
            }
              
            //return string.Compare(x.Name, y.Name);
        }
    }
}

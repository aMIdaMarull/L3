using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class SummerFactory : ISeasonalClothingFactory
    {
        public IClothing CreateClothing()
        {
            return new SummerClothing();
        }

        public IShoes CreateShoes()
        {
            return new SummerShoes();
        }
    }
}

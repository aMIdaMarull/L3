using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class WinterFactory : ISeasonalClothingFactory
    {
        public IClothing CreateClothing()
        {
            return new WinterClothing();
        }

        public IShoes CreateShoes()
        {
            return new WinterShoes();
        }
    }
}

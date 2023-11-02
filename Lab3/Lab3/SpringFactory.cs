using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class SpringFactory : ISeasonalClothingFactory
    {
        public IClothing CreateClothing()
        {
            return new SpringClothing();
        }

        public IShoes CreateShoes()
        {
            return new SpringShoes();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class AutumnFactory : ISeasonalClothingFactory
    {
        public IClothing CreateClothing()
        {
            return new AutumnClothing();
        }

        public IShoes CreateShoes()
        {
            return new AutumnShoes();
        }
    }
}

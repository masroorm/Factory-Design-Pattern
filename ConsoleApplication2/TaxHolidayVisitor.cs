using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TaxHolidayVisitor : IVisitor
    {
        public TaxHolidayVisitor()
        {

        }

        public double Visit(Necessities necessitiesItem)
        {
            Console.WriteLine($"{necessitiesItem}: Price With Holiday Tax for Liquor Item");
            var price = necessitiesItem.GetPrice() * .10;
            return price;
        }

        public double Visit(Tobacco tobaccoItem)
        {
            Console.WriteLine($"{tobaccoItem}: Price With Holiday Tax for Liquor Item");
            var price = tobaccoItem.GetPrice() * .30;
            return price;
        }

        public double Visit(Liqour liquorItem)
        {
            Console.WriteLine($"{liquorItem}: Price With Holiday Tax for Liquor Item");
            var price = liquorItem.GetPrice();
            return price;
        }
    }
}

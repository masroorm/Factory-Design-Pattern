using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TaxVisitor : IVisitor
    {
        public TaxVisitor()
        {

        }

        public double Visit(Necessities necessitiesItem)
        {
            Console.WriteLine($"{necessitiesItem}: Price With Tax for Necessities Item");
            var price = necessitiesItem.GetPrice() * .18;
            return price;
        }

        public double Visit(Tobacco tobaccoItem)
        {
            Console.WriteLine($"{tobaccoItem}: Price With Tax for Tobacco Item");
            var price = tobaccoItem.GetPrice() * .32;
            return price;
        }

        public double Visit(Liqour liquorItem)
        {
            Console.WriteLine($"{liquorItem}: Price With Tax for Liquor Item");
            var price = liquorItem.GetPrice();
            return price;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TaxVisitor : IVisitor
    {
        public double? Visit(Liqour liquor)
        {
            Console.WriteLine("Liqour Tax Price");
            return liquor.GetPrice() * .85;
        }

        public double? Visit(Food food)
        {
            Console.Write("Food Tax Price");
            return food.GetPrice() * 0.05;
        }

        public double? Visit(Tobacco tobacco)
        {
            Console.Write("Tobacco Tax Price");
            return tobacco.GetPrice() * 0.7;
        }
    }
}

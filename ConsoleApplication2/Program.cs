using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var taxCalc = new TaxVisitor();
            var taxHolidayCalc = new TaxHolidayVisitor();

            var milk = new Necessities();
            var vodka = new Liqour();
            var smokes = new Tobacco();
            milk.SetPrice(3.47);
            vodka.SetPrice(15.99);
            smokes.SetPrice(6.99);

            Console.WriteLine(milk.Accept(taxCalc));
            Console.WriteLine(vodka.Accept(taxCalc));
            Console.WriteLine(smokes.Accept(taxCalc));
            Console.WriteLine(milk.Accept(taxHolidayCalc));
            Console.WriteLine(vodka.Accept(taxHolidayCalc));
            Console.WriteLine(smokes.Accept(taxHolidayCalc));

            Console.ReadLine();

        }
    }


   
}

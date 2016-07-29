using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tax = new TaxVisitor();

            var dollarburger = new Food();
            dollarburger.SetPrice(1.00);
            var camels = new Tobacco();
            camels.SetPrice(6.59);
            var vodka = new Liqour();
            vodka.SetPrice(11.99);

            

            Console.WriteLine(dollarburger.Accept(tax));
            Console.WriteLine(camels.Accept(tax));
            Console.WriteLine(vodka.Accept(tax));
            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public interface IVisitor
    {
        double Visit(Liqour liquorItem);
        double Visit(Tobacco tobaccoItem);
        double Visit(Necessities necessitiesItem);
    }
}

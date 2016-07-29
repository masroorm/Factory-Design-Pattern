using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IVisitor
    {
        double? Visit(Liqour booze);
        double? Visit(Tobacco smokes);
        double? Visit(Food junk);
    }
}

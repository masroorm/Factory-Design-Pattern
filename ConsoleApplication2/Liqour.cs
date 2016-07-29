using System;

namespace ConsoleApplication2
{
    public class Liqour : IVisitable
    {

        private double Price { get; set; }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }


        public void SetPrice(double price)
        {
            Price = price;
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}
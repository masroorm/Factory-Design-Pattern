using System;

namespace ConsoleApplication1
{
    public class Food : IVisitable
    {
        private double? Price { get; set; }

        public double? Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public double? GetPrice()
        {
            return Price;
        }

        public void SetPrice(double? price)
        {
            Price = price;
        }
    }
}
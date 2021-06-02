using System;
using System.Globalization;

namespace StockProducts
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double StockValue()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantity
                + " unidades, Total: $ "
                + StockValue().ToString("F2", CultureInfo.InvariantCulture)
                ;
        }
    }
}
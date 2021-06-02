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

        public void AddProducts(int quantityAdd)
        {
            Quantity += quantityAdd;
        }

        public void RemoveProducts(int quantityRem)
        {
            Quantity -= quantityRem;
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
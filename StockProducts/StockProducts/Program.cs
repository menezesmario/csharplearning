using System;
using System.Globalization;

namespace StockProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);
        }
    }
}




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
            p.Price = double.Parse(Console.ReadLine(),
            CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int qt = int.Parse(Console.ReadLine());
            p.AddProducts(qt);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem removidos ao estoque: ");
            qt = int.Parse(Console.ReadLine());
            p.RemoveProducts(qt);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}




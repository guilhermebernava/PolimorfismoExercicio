using System;
using System.Collections.Generic;
using System.Linq;
using ExercicioPolimorfismo.Entities;
using ExercicioPolimorfismo.Entities.Enum;


namespace ExercicioPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of Products: ");
            int n = Int32.Parse(Console.ReadLine());
            #region FOR
            for (int i = 1; i<= n; i++)
            {
                Console.WriteLine($"Product #{i} data");
                Console.Write("Common, used or imported ? (Common/Used/Imported)?");
                TypeProducts typeProduct = Enum.Parse<TypeProducts>(Console.ReadLine());
                switch (typeProduct) 
                {
                    case 0:
                        Product product = new Product();
                        Console.Write("Name: ");
                        product.Name = Console.ReadLine();
                        Console.Write("Price: ");
                        product.Price = double.Parse(Console.ReadLine());
                        products.Add(product);
                        break;
                    case (TypeProducts)1:
                        UsedProduct productUsed = new UsedProduct();
                        Console.Write("Name: ");
                        productUsed.Name = Console.ReadLine();
                        Console.Write("Price: ");
                        productUsed.Price = double.Parse(Console.ReadLine());
                        Console.Write("Manufacutre date (DD/MM/YYYY): ");
                        productUsed.ManufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        products.Add(productUsed);
                        break;
                    case (TypeProducts)2:
                        ImportedProduct productImported = new ImportedProduct();
                        Console.Write("Name: ");
                        productImported.Name = Console.ReadLine();
                        Console.Write("Price: ");
                        productImported.Price = double.Parse(Console.ReadLine());
                        Console.Write("Customs fee: ");
                        productImported.CustomsFee = double.Parse(Console.ReadLine());
                        productImported.TotalPrice();
                        products.Add(productImported);
                        break;
                }
            }
            #endregion //FIM DO FOR
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            #region FOREACH
            foreach (Product pdc in products)
            {
                Console.WriteLine(pdc.PriceTag());
            }
            #endregion//Fim do FOREACH
        }
    }
}

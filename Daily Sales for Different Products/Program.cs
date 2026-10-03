using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Sales_for_Different_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] ProductSales = new int[3][];
            ProductSales[0] = new int[] { 100, 200, 150 }; 
            ProductSales[1] = new int[] { 300, 400 };     
            ProductSales[2] = new int[] { 500, 600, 550, 700 };

            for (int i = 0; i < ProductSales.Length; i++)
            {
                Console.Write($"Product {i+1 }: ");

                foreach (var sale in ProductSales[i])
                {
                    Console.Write(sale + " ");
                }
                Console.WriteLine();
            }


        }
    }
}

using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _15._10_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___Task1___");
            int[] ints = { 135, 435, 23, 54, 67, 75, 18, };
            Array.Sort(ints);
            Console.WriteLine("Minimal value :: " + ints[0]);

            Console.WriteLine("___Task2___");
            int min = 0;
            int max = 10;
            int[] test2 = new int[5];
            Random rnd = new Random();
            int[] ints2 = new int[10];
            for (int i = 0; i < ints2.Length; i++)
            {
                ints2[i] = rnd.Next(0, 10);
                Console.Write(ints2[i] + "  ");

            }
            Console.WriteLine();
            
            if (ints2.Length != ints2.Distinct().Count())
            {
                Console.WriteLine("Contains duplicates");
            }
            else
            {
                Console.WriteLine("Not contains duplicates");
            }
            
            Console.WriteLine("___Task3___");
            int[] ints3 = { 135, 435, 23, 54, 67, 75, 18, };
            int[] matchedItems = Array.FindAll(ints3, x => x % 2 == 0);
            for (int ctr = 0; ctr < matchedItems.Length; ctr++)
            {
                Console.Write("{0}  ", matchedItems[ctr]);
                
            }
        }
    }
}

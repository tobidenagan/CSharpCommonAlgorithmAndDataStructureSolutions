using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1234567890");
           // drawSymbol(10);
           // minMax(new List<long>(){ 256741038,623958417,467905213,714532089,938071625});
            MaxCount(new List<int> { 3, 2, 1, 3 });
        }

        static void drawSymbol(int n) {
            StringBuilder symbol = 
                new StringBuilder("#".Length * n).Insert(0, "#", n);
         
            string symbolXtra = symbol.ToString();
            for (int i = 0, j = n - 1; i < n; i++, j--)
            {
                Console.WriteLine(
                    symbol.Replace("#", " ", 0, j));
                symbol.Clear();
                symbol.Append(symbolXtra);
              
            }

        }

        static void minMax(List<long> n)
        {
            var nMax = n.Max();
            var nMin = n.Min();
            var Sum = n.Sum();
            Console.WriteLine((Sum - nMax) + " " + (Sum - nMin));
        }

        static void MaxCount(List<int> n)
        {

            Console.WriteLine(n.Where(x => x == n.Max()).Count());

            Console.WriteLine((from x in n where x == n.Max() select x).Count());


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                sum += i;
            }
            
            Console.WriteLine($"1から100までの合計（3の倍数を除く）: {sum}");
        }
    }
}

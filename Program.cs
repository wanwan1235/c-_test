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
            
            Console.WriteLine("=== Issue #1: 1から100までの合計計算 ===");
            
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"[DEBUG] 現在の値: {i}, 累計: {sum + i}");
                sum += i;
            }
            
            Console.WriteLine($"\n結果: 1から100までの合計 = {sum}");
            Console.WriteLine("期待値: 5050");
            Console.WriteLine($"計算確認: {(sum == 5050 ? "✅ 正確" : "❌ エラー")}");
        }
    }
}

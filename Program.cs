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
            
            Console.WriteLine("=== Issue #3: 1から200まで（7で割り切れる数のみ）の合計計算 ===");
            
            int sum = 0;
            for (int i = 1; i <= 200; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine($"[DEBUG] 加算: {i}, 累計: {sum + i}");
                    sum += i;
                }
            }
            
            Console.WriteLine($"\n結果: 1から200まで（7で割り切れる数のみ）の合計 = {sum}");
            Console.WriteLine("期待値: 2842");
            Console.WriteLine($"計算確認: {(sum == 2842 ? "✅ 正確" : "❌ エラー")}");
        }
    }
}

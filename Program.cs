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
            
            Console.WriteLine("=== Issue #2: 1から100まで（3の倍数除外）の合計計算 ===");
            
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"[DEBUG] {i}は3の倍数のためスキップ");
                    continue;
                }
                Console.WriteLine($"[DEBUG] 加算: {i}, 累計: {sum + i}");
                sum += i;
            }
            
            Console.WriteLine($"\n結果: 1から100まで（3の倍数除外）の合計 = {sum}");
            Console.WriteLine("期待値: 3367");
            Console.WriteLine($"計算確認: {(sum == 3367 ? "✅ 正確" : "❌ エラー")}");
        }
    }
}

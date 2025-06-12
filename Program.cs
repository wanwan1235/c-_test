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
            
            Console.WriteLine("=== Issue #1: 1から100までの8の倍数のみ合計計算 ===");
            
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 8 == 0)
                {
                    Console.WriteLine($"[DEBUG] 8の倍数加算: {i}, 累計: {sum + i}");
                    sum += i;
                }
                else
                {
                    Console.WriteLine($"[DEBUG] {i}は8の倍数ではないためスキップ");
                }
            }
            
            Console.WriteLine($"\n結果: 1から100までの8の倍数の合計 = {sum}");
            Console.WriteLine("期待値: 624 (8+16+24+32+40+48+56+64+72+80+88+96)");
            Console.WriteLine($"計算確認: {(sum == 624 ? "✅ 正確" : "❌ エラー")}");
        }
    }
}

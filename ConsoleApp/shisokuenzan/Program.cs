using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // 演算子の入力
            Console.WriteLine("演算子を一つ入力してください (+, -, *, /):");
            var operatorInput = Console.ReadLine();

            // 数値の入力
            Console.WriteLine("数値をスペース区切りで入力してください:");
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            // 演算結果の計算と表示
            var result = Calculate(operatorInput, numbers);
            Console.WriteLine($"演算結果は: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("入力が正しくありません。数値をスペース区切りで入力してください。");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("ゼロで割ることはできません。");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"エラーが発生しました: {ex.Message}");
        }
    }

    static int Calculate(string operatorInput, int[] numbers)
    {
        return operatorInput switch
        {
            "+" => numbers.Sum(),
            "-" => numbers.Aggregate((a, b) => a - b),
            "*" => numbers.Aggregate((a, b) => a * b),
            "/" => numbers.Aggregate((a, b) =>
            {
                if (b == 0) throw new DivideByZeroException();
                return a / b;
            }),
            _ => throw new InvalidOperationException("無効な演算子が入力されました。")
        };
    }
}
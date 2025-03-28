class Program
{
    static void Main(params string[] args)
    {
        // コンソールに演算子を入力。
        Console.WriteLine("演算子を一つ入力してください。");
        var enzanshi = Console.ReadLine();
        Console.WriteLine("数値をスペース空けて入力してください。");
        var baseValue = Console.ReadLine();
        var lastValue = 0;
        var middleValue = 1;
        if (enzanshi == "+")
        {
            foreach (var value in baseValue)
            {
                lastValue += value;
            }
            Console.WriteLine($"演算結果は、{lastValue}です");
        }
        if (enzanshi == "-")
        {
            foreach (var value in baseValue)
            {
                lastValue -= value;
            }
            Console.WriteLine($"演算結果は、{lastValue}です");
        }
        if (enzanshi == "*")
        {
            foreach (var value in baseValue)
            {
                middleValue *= value;
            }
            Console.WriteLine($"演算結果は、{middleValue}です");
        }
        if (enzanshi == "/")
        {
            foreach (var value in baseValue)
            {
                middleValue /= value;
            }
            Console.WriteLine($"演算結果は、{middleValue}です");
        }

        // 数字を複数入力し、その数値に対して先ほどの演算子を適用
        // 適用結果をコンソールに表示する
    }
}
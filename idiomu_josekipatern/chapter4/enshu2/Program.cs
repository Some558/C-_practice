Console.WriteLine("数字を入力してください");
if (!int.TryParse(Console.ReadLine(), out int line))
{
    Console.WriteLine("入力値に誤りがあります");
}
else
{
    Console.WriteLine("結果を判定します");

    var result = line switch
    {
        < 0 or >= 500 => line,
        < 100 => line * 2,
        < 500 => line * 3
    };

    Console.WriteLine(result);
}

// {
//     Console.WriteLine(line);
// }
// else if (0 <= line && line < 100)
// {
//     Console.WriteLine(line * 2);
// }
// else if (100 <= line && line < 500)
// {
//     Console.WriteLine(line * 3);
// }
// else if (line >= 500)
// {
//     Console.WriteLine(line);
// }
// else
// {
//     Console.WriteLine("入力値に誤りがあります");
// }

// switch (line)
// {
//     case < 0:
//     case >= 500:
//         // valueが10なら10を表示
//         Console.WriteLine(line);
//         break;
//     case < 100:
//         // valueが11なら11を表示
//         Console.WriteLine(line * 2);
//         break;
//     case < 500:
//         // valueが12なら12を表示
//         Console.WriteLine(line * 3);
//         break;
//     default:
//         Console.WriteLine("みすがあるよ");
// }



// エラー解消から
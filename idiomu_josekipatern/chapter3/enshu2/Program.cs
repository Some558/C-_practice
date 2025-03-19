var cities = new List<string>
{
    "Tokyo", "New Delhi","Bangkok", "London", "Paris", "Berlin",
     "Canberra", "Hong Kong",
};

Console.WriteLine("都市名を入力。空行で終了");
do
{
    var line = Console.ReadLine();
    if (string.IsNullOrEmpty(line))
        break;
    var index = cities.FindIndex(s => s == line);
    Console.WriteLine(index);
} while (true);


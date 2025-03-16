var numbers = new List<int>
{
    12,87,94,14,53,20,40,35,76,91,31,17,48
};

// var eightOrNine = numbers.Exists(x => x % 8 == 0 || x % 9 == 0);
// Console.WriteLine(eightOrNine);

// numbers.ForEach(s => Console.WriteLine(s / 2));

// IEnumerable<int> query = numbers.Where(s => s >= 50);
// foreach (var s in query)
// {
//     Console.WriteLine(s);
// }

var doubleScore = numbers.Select(s => s * 2).ToList();
foreach (var s in doubleScore)
{
    Console.WriteLine(s);
}

using SalesCalculator;

var sales = new SalesCounter("sales.csv");
// 右辺のメソッドの戻り値から型を推測
var amountsPerStore = sales.GetPerStoreSales();
foreach(var obj in amountsPerStore)
{
    Console.WriteLine($"{obj.Key}{obj.Value}");
}
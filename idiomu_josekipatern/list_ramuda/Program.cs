// List<T>型
var cities = new List<string>{
    "Tokyo", "New Delhi", "Bengkok", "London", "Paris", "Berlin",
    "Canberra", "Hong Kong",
};

// Existsメソッド
// 条件に一致した要素が存在するか調べてtrueかfalseで返す
// s[0]は文字の最初を表す
var exists = cities.Exists(s => s[0] == 'B');
Console.WriteLine(exists);

// Findメソッド
// 条件通りの物で最初に見つかったものを返す
var name = cities.Find(s=> s.Length == 6);
Console.WriteLine(name);

// FindIndexメソッド
// 条件に合った文字のインデックス番号を返す
int index = cities.FindIndex(s => s == "Berlin");
Console.WriteLine(index);

// FindAllメソッド
// 条件にあったすべてを返す
// sが二回出ているがスコープ違いなので問題なし
var names = cities.FindAll(s => s.Length <= 5);
foreach(var s in names)
{
    Console.WriteLine(s);
}

// RemoveAllメソッド
// 条件にあったものをリストから削除する
// 戻り値は削除した数
var removedCount = cities.RemoveAll(s => s.Contains("on"));
Console.WriteLine(removedCount);

// ForEachメソッド
// voidで出力できる
cities.ForEach(s => Console.WriteLine(s));

// ConvertAllメソッド
// 要素の型を変換し返す。cities事態は変化しない。
var lowerList = cities.ConvertAll(s => s.ToLower());
lowerList.ForEach(s => Console.WriteLine(s));
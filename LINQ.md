## LINQとは
Language Integrated Queryの略
LINQを使えば、オブジェクトやデーターベース、XMLなどさまざまなデータに対して問い合わせ処理が可能になる。

## クエリ演算子

whreメソッド
IEnumerable<string> query = cities.Where(s=>s.Length<=5);
findAllメソッドに似ているが、多くの型に利用できるのが違う点。
FindAllはList<T>にのみ利用できる。
whereはIEnumerable<T>を実装していれば、どんな型にも使える。

メソッドチェーン
IEnumerable<string> query = cities.Whre(s => s.Length <= 5).Select(s => s.ToLower());
foreach(string s in query)
{
    Console.WriteLine(s);
}

## シーケンス
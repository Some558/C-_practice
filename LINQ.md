Language Integrated Queryの略
## LINQとは
LINQを使えば、オブジェクトやデーターベース、XMLなどさまざまなデータに対して問い合わせ処理が可能になる。
遅延実行されるという特徴があり、データが必要になったときにクエリが実行される。
即時実行したい場合にはToArray,ToListを用いる

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
IEnumerable<T>型のデータであるときに使われる

### どんなリンクがあるのかまとめ
Exists
Finf
FirstOrDefault
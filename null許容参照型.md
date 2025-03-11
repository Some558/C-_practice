## null許容参照型
// 下記は同じ意味である
Preson person;
Person person = null;

// stringにもnullを定義できる
string name = null;

// nullかどうかを確認する方法
if(name is null){
    Console.WriteLine("nameはnullです")
}

// boolやintにもnullを許容する方法
int? number = null;
使用例
int? number = null;

// null以外の値があるか調べる
if(number.HasValue)
{
    // Valueプロパティで値を取り出す
    Console.WriteLine($"num= {number.Value}");
}
else
{
    // 上記以外の場合はnullである
    Console.WriteLine("num = null");
}

//参照型でもnullを許容したい場合の書き方
string? nullableText = "program";
nullableText = null;

// プロパティにnull以外の値を入れておく方法
public string Name{get;set;} = string.Empty;
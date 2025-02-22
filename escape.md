### 改行して出力する
Console.WriteLine("Hello\nWorld!");
### タブスペースを空けて出力する
Console.WriteLine("Hello\tWorld!");
### 二重引用符を文字列とみなして出力する
Console.WriteLine("Hello \"World\"!");
### \を文字列とみなして出力する
Console.WriteLine("c:\\source\\repos");
### @を使用して空白を認識させる
Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)");
### @を使用して\を文字列として認識させる
Console.Write(@"c:\invoices");
### Unicodeの4文字をリテラル文字列に変換する
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
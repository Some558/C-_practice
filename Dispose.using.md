## disposeとは
特定のクラスは開いた後自動で閉じることができないため、disposeで明示的に閉じる必要がある。
インスタンス生成後、そのクラス使用時に. を押して候補が出てくれば、disposeを使用しないといけない。
## 例文

### 使い方①
public void insert()
    SqlConnection connection = new SqlConnection();
    connection.Open();
    // 処理
    connection.Dispose()
この使い方だと、Open後の処理によってはDisposeをスルーしてしまうかもしれない。

### 使い方②
public void insert()
    SqlConnection connection = new SqlConnection();
    try
    {
        connection.Open();
        // 処理
    }
    finally
    {
        connection.Dispose()
    }
// 処理で何が行われてもDisposeされる

### 使い方③
using(SqlConnection connection = new SqlConnection())
using(SqlConnection command = new SqlConnection())
{
    // 処理
}
// 中でどんな処理が行われようが、抜けた時には必ずDisposeされる
// 幾つでもusingを書ける

### プライベート変数の場合
public class Database:IDisposable
{
    private SqlDataAdapter _adapter = new SqlDataAdapter();
}
    // もし変数内がnullじゃなかったらdisposeする
    if(_adapter != null)
    {
        _adapter.Dispose();
    }
// このクラス自体がDisposeされる対象になる。
このクラスを使う側の書き方
public Form()
{
    InitializeComponent();
    using(Database db = new Database())
    {
        // 処理
    }
}
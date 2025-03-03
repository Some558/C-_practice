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
    connection.Open();
    // 処理
    connection.Dispose()

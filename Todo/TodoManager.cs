// タスク管理クラス
public class TodoManager
{
    private List<TodoTask> _tasks;
    private string _filePath;
    private int _nextId = 1;

    public TodoManager(string filePath = "tasks.json")
    {
        _tasks = new List<TodoTask>();
        _filePath = filePath;
    }

    // タスク追加メソッド
    public TodoTask AddTask(string title, string description = "")
    {
        var task = new TodoTask(_nextId++, title, description);
        _tasks.Add(task);
        return task;
    }

    // 他のメソッド（タスク取得、編集、削除、完了/未完了の切り替え）
    // ...

    // JSON保存メソッド
    public void SaveToFile()
    {
        // System.Text.Jsonを使ってシリアライズして保存
    }

    // JSONからの読み込みメソッド
    public void LoadFromFile()
    {
        // ファイルが存在すれば読み込む
    }
}
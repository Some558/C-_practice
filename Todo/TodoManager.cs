// タスク管理クラス
using System.Linq.Expressions;

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

    public List<TodoTask> GetAllTasks()
    {
        return _tasks;
    }

    public TodoTask GetTask(int id)
    {
        return _tasks.FirstOrDefault(t => t.Id == id);
    }

    public bool DeleteTask(int id)
    {
        var task = GetTask(id);
        if (task != null)
        {
            _tasks.Remove(task);
            return true;
        }
        return false;
    }
    // 他のメソッド（タスク取得、編集、削除、完了/未完了の切り替え）
    // ...

    // JSON保存メソッド
    public void SaveToFile()
    {
        try
        {
            string json = System.Text.Json.JsonSerializer.Serialize(_tasks);
            File.WriteAllText(_filePath, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"エラー：ファイルの保存に失敗しました。{ex.Message}");
        }
    }

    // JSONからの読み込みメソッド
    public void LoadFromFile()
    {
        // ファイルが存在すれば読み込む
    }
}
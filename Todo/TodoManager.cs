// タスク管理クラス
using System.Linq.Expressions;
using Newtonsoft.Json;

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
        var task = new TodoTask(_nextId, title, description);
        _tasks.Add(task);
        _nextId++;
        Console.WriteLine("タスクが追加されました");
        return task;
    }

    public void GetAllTasks()
    {
        try
        {
            if (File.Exists(_filePath))
            {
                // ファイルの内容を読み込む
                string todoJson = File.ReadAllText(_filePath);

                // JSONをC#のオブジェクトに変換
                _tasks = JsonConvert.DeserializeObject<List<TodoTask>>(todoJson) ?? new List<TodoTask>();

                // タスクを1つずつ表示
                Console.WriteLine("現在のタスク一覧:");
                foreach (var task in _tasks)
                {
                    Console.WriteLine($"Id: {task.Id}, Title: {task.Title}, Description: {task.Description}, IsCompleted: {task.IsCompleted}");
                }
            }
            else
            {
                Console.WriteLine("tasks.json ファイルが存在しません。");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"エラー：タスクの読み込みに失敗しました。{ex.Message}");
        }
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
        try
        {
            if (File.Exists(_filePath))
            {
                string todoJson = File.ReadAllText(_filePath);
                _tasks = JsonConvert.DeserializeObject<List<TodoTask>>(todoJson) ?? new List<TodoTask>();
                // Anyは空ではない場合にtrueを返す
                // Idの最大値を確認し、その数値に+1したものをnextIdとする。
                _nextId = _tasks.Any() ? _tasks.Max(t => t.Id) + 1 : 1;
            }
            else
            {
                _tasks = new List<TodoTask>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"エラー：ファイルの読み込みに失敗しました。{ex.Message}");
            _tasks = new List<TodoTask>();
        }
    }
}
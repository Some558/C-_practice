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

    // 全てのタスクを読み込む
    public void GetCompleteTasks()
    {
        try
        {
            if (File.Exists(_filePath))
            {
                // ファイルの内容を読み込む
                string todoJson = File.ReadAllText(_filePath);

                // JSONをC#のオブジェクトに変換
                _tasks = JsonConvert.DeserializeObject<List<TodoTask>>(todoJson) ?? new List<TodoTask>();

                // 一つでもfalseがあれば、anyにtrueが入る
                var any = _tasks.Any(x => x.IsCompleted == false);
                // 一つでもfalse（未完了）があればこっちを表示する
                if (any == true)
                {
                    Console.WriteLine("未完了のタスクはこちらです。");
                    foreach (var task in _tasks)
                    {
                        if (task.IsCompleted == false)
                        {
                            Console.WriteLine($"Id: {task.Id}, Title: {task.Title}, Description: {task.Description}, IsCompleted: {task.IsCompleted}");
                        }
                    }
                }
                // 全てtrue（完了）であればこっちを表示する
                else
                {
                    Console.WriteLine("未完了のタスクはありません");
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

    // タスク追加メソッド
    public TodoTask AddTask(string title, string description = "")
    {
        var task = new TodoTask(_nextId, title, description);
        _tasks.Add(task);
        _nextId++;
        Console.WriteLine("タスクが追加されました");
        return task;
    }

    // タスクの編集
    public void EditTask(TodoTask task)
    {
        Console.WriteLine("タイトルを入力してください");
        var title = Console.ReadLine();
        Console.WriteLine("タスクの説明を入力してください");
        var description = Console.ReadLine();
        task.Title = title;
        task.Description = description;
        Console.WriteLine("タスクの編集が完了しました");
    }

    // タスクを削除する
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

    // タスクの状態によって完了、未完了を切り替える
    public void ChangeTask(int id)
    {
        var task = GetTask(id);
        if (task != null)
        {
            if (task.IsCompleted == false)
            {
                task.IsCompleted = true;
            }
            else
            {
                task.IsCompleted = false;
            }
        }
        else
        {
            Console.WriteLine("指定のIDは存在しません");
        }
        // bool IsCompleted の値をtrueにする
        // IDを引数としてもらい、そのリストのisCompletedをtrueにする
    }

    public void GetInCompleteTasks()
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
                Console.WriteLine("完了済のタスクはこちらです。");
                foreach (var task in _tasks)
                {
                    if (task.IsCompleted == true)
                    {
                        Console.WriteLine($"Id: {task.Id}, Title: {task.Title}, Description: {task.Description}, IsCompleted: {task.IsCompleted}");
                    }
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

    // JSON保存メソッド
    public void SaveToFile()
    {
        try
        {
            string json = System.Text.Json.JsonSerializer.Serialize(_tasks);
            File.WriteAllText(_filePath, $"{json}{Environment.NewLine}");
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
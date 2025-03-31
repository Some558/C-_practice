using System.Reflection;

class Program
{
    static TodoManager todoManager;

    static void Main(string[] args)
    {
        todoManager = new TodoManager();
        todoManager.LoadFromFile(); // 起動時にデータを読み込む

        bool exit = false;
        while (!exit)
        {
            DisplayMenu();
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    todoManager.GetAllTasks();
                    break;
                case "2":
                    Console.WriteLine("タスクのタイトルを入力してください");
                    string title = Console.ReadLine();
                    Console.WriteLine("タスクの説明をしてください");
                    string description = Console.ReadLine();
                    todoManager.AddTask(title, description);
                    break;
                case "3":
                    Console.WriteLine("編集したいタスクのIDを入力してください");
                    // 入力された値をint型にしてeditTaskに代入
                    var editTask = int.Parse(Console.ReadLine());
                    // GetTaskメソッドによって指定のIDが見つかれば、そのIDのリストを返してtaskに代入
                    var task = todoManager.GetTask(editTask);
                    // taskはリスト型の状態でEditTaskに渡す
                    todoManager.EditTask(task);
                    break;
                case "4":
                    Console.WriteLine("どのタスクを削除しますか？（番号を入力[例：1]）");
                    var deleteTask = int.Parse(Console.ReadLine());
                    todoManager.DeleteTask(deleteTask);
                    break;
                case "5":
                    Console.WriteLine("どのタスクのステータスを変更しますか（番号を入力[例：1]）");
                    var changeTask = int.Parse(Console.ReadLine());
                    todoManager.ChangeTask(changeTask);
                    break;
                case "0":
                    exit = true;
                    break;
            }

            // ユーザーの選択に基づいて処理を実行
            // ...
            todoManager.SaveToFile(); // 操作後にデータを保存        
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\n===== ToDo List Manager =====");
        Console.WriteLine("1. タスク一覧を表示");
        Console.WriteLine("2. 新しいタスクを追加");
        Console.WriteLine("3. タスクを編集");
        Console.WriteLine("4. タスクを削除");
        Console.WriteLine("5. タスクのステータスを切り替え");
        Console.WriteLine("0. 終了");
        Console.Write("選択してください: ");
    }

    // 他のメソッド（タスク表示、追加、編集、削除のUI実装）
    // ...
}
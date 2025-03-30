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

            // ユーザーの選択に基づいて処理を実行
            // ...
            try
            {
                if (choice == "1")
                {

                }

            }
            catch
            {

            }

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
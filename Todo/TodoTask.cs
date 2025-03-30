// タスククラス
public class TodoTask
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? CompletedDate { get; set; }

    public TodoTask(int id, string title, string description = "")
    {
        Id = id;
        Title = title;
        Description = description;
        IsCompleted = false;
        CreatedDate = DateTime.Now;
        CompletedDate = null;
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
        CompletedDate = DateTime.Now;
    }

    public void MarkAsIncomplete()
    {
        IsCompleted = false;
        CompletedDate = null;
    }
}
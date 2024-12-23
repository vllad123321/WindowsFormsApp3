using System;

public class TaskItem
{
    public string Text { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastEditedAt { get; set; }
    public DateTime? LastOpenedAt { get; set; }

    public override string ToString()
    {
        return $"{Text} (Добавлено: {CreatedAt:G})";
    }
}

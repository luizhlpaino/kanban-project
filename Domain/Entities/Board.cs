namespace Domain.Entities;

public class Board
{
    public Guid guid { get; set; }
    public string title { get; set; }
    public DateTime created_at { get; set; }
}

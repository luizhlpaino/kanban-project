namespace Domain.Entities;

public class BoardColumn
{
    public Guid guid { get; set; }
    public string title { get; set; }
    public Board board { get; set; }
}

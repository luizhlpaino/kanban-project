namespace Domain.Entities;

public class Card
{
    public Guid guid { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public BoardColumn boardColumn { get; set; }    
}

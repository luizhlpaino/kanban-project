namespace Domain.Commands.Responses;

public class CreateBoardResponse
{
    public Guid guid { get; set; }
    public string title { get; set; }
    public DateTime created_at { get; set; }
}

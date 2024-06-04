using Domain.Commands.Responses;
using MediatR;

namespace Domain.Commands.Requests;

public class CreateBoardRequest: IRequest<CreateBoardResponse>
{    
    public string title { get; set; }    
}

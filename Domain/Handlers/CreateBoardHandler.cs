using Domain.Commands.Requests;
using Domain.Commands.Responses;
using MediatR;

namespace Domain.Handlers;

public class CreateBoardHandler: IRequestHandler<CreateBoardRequest, CreateBoardResponse>
{   
    public Task<CreateBoardResponse> Handle(CreateBoardRequest request, CancellationToken cancellationToken)
    {
        var result = new CreateBoardResponse {
            guid = Guid.NewGuid(),
            title = "Novo Board",
            created_at = DateTime.Now,
        };

        return Task.FromResult(result);
    }
}

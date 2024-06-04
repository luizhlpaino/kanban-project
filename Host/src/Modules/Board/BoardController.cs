using Domain.Commands.Requests;
using Domain.Commands.Responses;
using Domain.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Host.Controllers;

[ApiController]
[Route("[controller]")]
public class BoardController: ControllerBase
{
    public BoardController() {}

    [HttpGet]
    public void GetAll() {

    }

    [HttpPost] 
    public Task<CreateBoardResponse> Create(
        [FromServices] IMediator mediator, 
        [FromBody] CreateBoardRequest command
    ) {
        return mediator.Send(command);
    }
}

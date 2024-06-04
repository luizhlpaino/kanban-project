using Microsoft.AspNetCore.Mvc;

namespace Kanban.Host.Controllers;

[ApiController]
[Route("[controller]")]
public class CardController: ControllerBase 
{
    public CardController() {}    

    [HttpGet]        
    public string GetAll() {
        return "Not implemented yet";
    }

    [HttpPost]
    public void Post() {

    }
}
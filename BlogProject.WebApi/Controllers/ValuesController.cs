using BlogProject.WebApi.Abstractions;
using MediatR;

namespace BlogProject.WebApi.Controllers;


public class ValuesController : ApiController
{
    public ValuesController(IMediator mediator) : base(mediator)
    {
    }
}

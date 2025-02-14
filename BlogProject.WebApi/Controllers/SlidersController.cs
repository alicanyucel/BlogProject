

using BlogProject.WebApi.Abstractions;
using MediatR;

namespace BlogProject.WebApi.Controllers
{
    public class SlidersController : ApiController
    {
        public SlidersController(IMediator mediator) : base(mediator)
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Liberyus.WebApi.Abstractions;
using MediatR;
using BlogProject.Application.Features.Slider.CreateSlider;
using Microsoft.AspNetCore.Authorization;
using BlogProject.Application;
[AllowAnonymous]


public class SliderController :ApiController
{
    public SliderController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateSliderCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    [HttpPost]
    public async Task<IActionResult> GetAllSlider(GetAllSliderQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

}

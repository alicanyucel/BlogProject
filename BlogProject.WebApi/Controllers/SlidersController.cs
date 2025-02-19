using Microsoft.AspNetCore.Mvc;
using Liberyus.WebApi.Abstractions;
using MediatR;
using BlogProject.Application.Features.Slider.CreateSlider;
using Microsoft.AspNetCore.Authorization;
using BlogProject.Application;
using BlogProject.Application.Features.Slider.DeleteSlider;
using BlogProject.Application.Features.Slider.UpdateSlider;
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
    [HttpPost]
    public async Task<IActionResult> DeleteSliderByIdCommandHandler(DeleteSliderByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost]
    public async Task<IActionResult> UpdateSliderByIdCommandHandler(UpdateSliderByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}

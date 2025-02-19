using MediatR;
using TS.Result;

namespace BlogProject.Application.Features.Slider.DeleteSlider
{
    public sealed record DeleteSliderByIdCommand(int Id) : IRequest<Result<string>>;
}

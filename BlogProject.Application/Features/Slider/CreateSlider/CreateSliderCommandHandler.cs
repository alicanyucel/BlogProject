

using AutoMapper;
using BlogProject.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace BlogProject.Application.Features.Slider.CreateSlider;

internal sealed class CreateSliderCommandHandler(ISliderRepository sliderRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<CreateSliderCommand, Result<string>>
{
    public ISliderRepository SliderRepository { get; } = sliderRepository;

    public async Task<Result<string>> Handle(CreateSliderCommand request, CancellationToken cancellationToken)
    {

        Domain.Slider slider = mapper.Map<Domain.Slider>(request);

        await SliderRepository.AddAsync(slider, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Slider Added";
    }
}



using AutoMapper;
using BlogProject.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace BlogProject.Application.Features.Slider.UpdateSlider
{
    internal sealed class UpdateSLİDERByIdCommandHandler(ISliderRepository sliderRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<UpdateSliderByIdCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(UpdateSliderByIdCommand request, CancellationToken cancellationToken)
        {
            Domain.Slider? slider = await sliderRepository.GetByExpressionWithTrackingAsync(P => P.SliderId == request.SliderId, cancellationToken);
            if (slider == null)
            {
                return Result<string>.Failure("slider not found");
            }
            mapper.Map(request, slider);
            sliderRepository.Update(slider);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return "Slider update is successful";
        }
    }
}

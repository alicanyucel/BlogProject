using BlogProject.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;
using BlogProject.Application.Features.Slider.DeleteSlider;
namespace BlogProject.Application.Features;

internal sealed class DeleteCommentByIdCommandHandler(
   ISliderRepository sliderRepository,
  IUnitOfWork unitOfWork) : IRequestHandler<DeleteSliderByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteSliderByIdCommand request, CancellationToken cancellationToken)
    {
       Domain.Slider slider= await sliderRepository.GetByExpressionAsync(p => p.SliderId == request.Id, cancellationToken);
        if (slider is null)
        {
            return Result<string>.Failure("Slider not found");
        }

        sliderRepository.Delete(slider);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Slider delete is successful";
    }
}

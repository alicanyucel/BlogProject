

using BlogProject.Domain;
using BlogProject.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Application;

internal sealed class GetAllSliderQueryHandler : IRequestHandler<GetAllSliderQuery, List<Slider>>
{
    private readonly ISliderRepository _sliderRepository;

    public GetAllSliderQueryHandler(ISliderRepository sliderRepository)
    {
        _sliderRepository = sliderRepository;
    }

    public async Task<List<Slider>> Handle(GetAllSliderQuery request, CancellationToken cancellationToken)
    {
        return await _sliderRepository.GetAll().OrderBy(p => p.Title).ToListAsync(cancellationToken);
    }
}

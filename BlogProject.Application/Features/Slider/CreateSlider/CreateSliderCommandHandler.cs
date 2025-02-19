

using AutoMapper;
using BlogProject.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace BlogProject.Application.Features.Slider.CreateSlider;

internal sealed class CreateSliderCommandHandler : IRequestHandler<CreateSliderCommand, Result<string>>
{
    private readonly ISliderRepository _sliderRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    // Constructor dependency injection
    public CreateSliderCommandHandler(ISliderRepository sliderRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _sliderRepository = sliderRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<string>> Handle(CreateSliderCommand request, CancellationToken cancellationToken)
    {
        // CreateSliderCommand'dan gelen veriyi Slider nesnesine map et
        Domain.Slider slider = _mapper.Map<Domain.Slider>(request);

        // LanguageId'yi Slider nesnesine doğru şekilde atıyoruz
        slider.LanguageId = request.LanguageId;

        // Slider'ı veritabanına ekleyelim
        await _sliderRepository.AddAsync(slider, cancellationToken);

        // Veritabanına kaydedelim
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        // Başarı mesajı dönüyoruz
        return Result<string>.Succeed("Slider Added");
    }
}
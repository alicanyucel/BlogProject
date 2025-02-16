using MediatR;
using TS.Result;

namespace BlogProject.Application.Features.Slider.CreateSlider
{
    

    public record CreateSliderCommand(
        int RowNumber,
        string? Name,
        string? Title,
        string? Description,
        bool Status,
        string? ImageName,
        string? ImageNameMobile,
        int ClickCount,
        bool NoIndex,
        bool IsLink,
        string? LinkUrl,
        bool LinkOut,
        string? SeoTitle,
        string? SeoDescription,
        string? SeoKeyword,
        Guid LanguageId // Foreign key olarak LanguageId ekleniyor
    ) : IRequest<Result<string>>;

}

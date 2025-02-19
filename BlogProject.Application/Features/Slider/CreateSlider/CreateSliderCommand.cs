using MediatR;
using TS.Result;

namespace BlogProject.Application.Features.Slider.CreateSlider
{
    // CreateSliderCommand ile Slider'ın yaratılmasını sağlıyoruz
    public record CreateSliderCommand(
        int RowNumber,               // Slider satır numarası
        string? Name,                // Slider ismi
        string? Title,               // Başlık
        string? Description,         // Açıklama
        bool Status,                 // Durum (aktif/pasif)
        string? ImageName,           // Görsel adı
        string? ImageNameMobile,     // Mobil görsel adı
        int ClickCount,              // Tıklama sayısı
        bool NoIndex,                // SEO NoIndex
        bool IsLink,                 // Bağlantı durumu
        string? LinkUrl,             // Bağlantı URL'si
        bool LinkOut,                // Dış bağlantı durumu
        string? SeoTitle,            // SEO Başlık
        string? SeoDescription,      // SEO Açıklama
        string? SeoKeyword,
        int  LanguageId// Foreign key olarak LanguageId
    ) : IRequest<Result<string>>;  // Sonuç olarak string dönecek
}

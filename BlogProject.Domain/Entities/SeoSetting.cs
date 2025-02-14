
using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;

public class SeoSetting : Entity, IEntity
{
    [StringLength(100)]
    public string? SiteUrl { get; set; }
    public string? SeoTitle { get; set; }
    public string? SeoDescription { get; set; }
    public string? SeoKeyword { get; set; }
    public string? MetaTag { get; set; }
    public string? GoogleAnalyticscode { get; set; }
    public string? GoogleVerificationCode { get; set; }
    public string? BingVerificationCode { get; set; }
    public string? YandexVerificationCode { get; set; }
    public string? YandexMetrica { get; set; }
    public string? StructuredDataTool { get; set; }
    public string? WhatsAppSupport { get; set; }
    public string? LiveSupport { get; set; }
    public string? AddThis { get; set; }
    public string? VerificationCode1 { get; set; }
    public string? VerificationCode2 { get; set; }
    public string? VerificationCode3 { get; set; }
    public string? VerificationCode4 { get; set; }
    public string? VerificationCode5 { get; set; }
    public string? VerificationCode6 { get; set; }
    public string? VerificationCode7 { get; set; }
    public string? VerificationCode8 { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Language Language { get; set; }
}
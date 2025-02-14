
using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class Contact : IEntity
{
    [Key]
    public int ContactId { get; set; }
    public int LanguageId { get; set; }
    public int RowNumber { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Address { get; set; }
    public string? AddressLinkUrl { get; set; }
    public string? PhoneNumber { get; set; }
    public string? MobileNumber { get; set; }
    public string? WhatsappNumber { get; set; }
    public string? Email { get; set; }
    public string? Description { get; set; }
    public string? Maps { get; set; }
    public bool Status { get; set; }
    public string? ImageName { get; set; }
    public string? SeoTitle { get; set; }
    public string? SeoDescription { get; set; }
    public string? SeoKeyword { get; set; }
    public string? InstagramLink { get; set; }
    public string? FacebookLink { get; set; }
    public string? TwitterLink { get; set; }
    public string? YoutubeLink { get; set; }
    public string? LinkedinLink { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Language Language { get; set; }
}
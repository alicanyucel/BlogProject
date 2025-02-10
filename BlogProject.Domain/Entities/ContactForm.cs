
using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class ContactForm : IEntity
{
    [Key]
    public int ContactFormId { get; set; }
    public int LanguageId { get; set; }
    public int? ContactFormSubjectId { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Message { get; set; }
    public string? Description { get; set; }
    public string? ImageName { get; set; }
    public bool Status { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public ContactFormSubject ContactFormSubject { get; set; }
    public Language Language { get; set; }
}
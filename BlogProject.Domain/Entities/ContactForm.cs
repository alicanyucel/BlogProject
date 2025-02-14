
using BlogProject.Domain.Abstract;

namespace BlogProject.Domain;
public class ContactForm :Entity, IEntity
{
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
   // public Language Language { get; set; }
}
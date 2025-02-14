

using BlogProject.Domain.Abstract;
using BlogProject.DomaiN;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class DoctorSpokenLanguage : IEntity
{
    [Key]
    public int DoctorSpokenLanguageId { get; set; }
    public int DoctorId { get; set; }
    public int SpokenLanguageId { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Doctor Doctor { get; set; }
    public SpokenLanguage SpokenLanguage { get; set; }
}

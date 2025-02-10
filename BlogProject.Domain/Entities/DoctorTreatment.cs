using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class DoctorTreatment : IEntity
{
    [Key]
    public int DoctorTreatmentId { get; set; }
    public int DoctorId { get; set; }
    public int TreatmentId { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Doctor Doctor { get; set; }
    public Treatment Treatment { get; set; }
}

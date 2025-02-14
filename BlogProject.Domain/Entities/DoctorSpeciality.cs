using BlogProject.Domain.Abstract;
using BlogProject.DomaiN;


namespace BlogProject.Domain;
public class DoctorSpeciality :Entity, IEntity
{
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Doctor Doctor { get; set; }
    public Speciality Speciality { get; set; }
}
using BlogProject.Domain.Abstract;
using BlogProject.DomaiN;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class DoctorSpeciality : IEntity
{
    [Key]
    public int DoctorSpecialityId { get; set; }
    public int DoctorId { get; set; }
    public int SpecialityId { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Doctor Doctor { get; set; }
    public Speciality Speciality { get; set; }
}
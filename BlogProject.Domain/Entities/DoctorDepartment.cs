
using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class DoctorDepartment : IEntity
{
    [Key]
    public int DoctorDepartmentId { get; set; }
    public int DoctorId { get; set; } = 0;
    public int DepartmentId { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Doctor Doctor { get; set; }
    public Department Department { get; set; }
}

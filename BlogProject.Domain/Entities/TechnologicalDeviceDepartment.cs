using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class TechnologicalDeviceDepartment : IEntity
{
    [Key]
    public int TechnologicalDeviceDepartmentId { get; set; }
    public int? TechnologicalDeviceId { get; set; }
    public int? DepartmentId { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public TechnologicalDevice TechnologicalDevice { get; set; }
    public Department Department { get; set; }
}


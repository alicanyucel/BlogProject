

using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class TechnologicalDeviceDepartment :Entity,IEntity
{
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public TechnologicalDevice TechnologicalDevice { get; set; }
    public Department Department { get; set; }
}
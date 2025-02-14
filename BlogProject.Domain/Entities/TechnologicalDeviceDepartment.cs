

using BlogProject.Domain.Abstract;

namespace BlogProject.Domain;
public class TechnologicalDeviceDepartment : Entity, IEntity
{
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }

    // Foreign Key'ler
    public Guid TechnologicalDeviceId { get; set; }
    public TechnologicalDevice TechnologicalDevice { get; set; }

    public Guid DepartmentId { get; set; }
    public Department Department { get; set; }
}

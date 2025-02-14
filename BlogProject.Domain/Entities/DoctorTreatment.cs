

using BlogProject.Domain;
using BlogProject.Domain.Abstract;


namespace BlogProject.Domai;
public class DoctorTreatment :Entity, IEntity
{
  
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Doctor Doctor { get; set; }
    public Treatment Treatment { get; set; }
}
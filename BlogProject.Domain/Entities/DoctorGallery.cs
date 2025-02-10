using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class DoctorGallery : IEntity
{
    [Key]
    public int DoctorGalleryId { get; set; }
    public int DoctorId { get; set; }
    public int RowNumber { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }
    public string? ImageName { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Doctor Doctor { get; set; }
}

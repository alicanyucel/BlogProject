

using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class BlogGallery : IEntity
{
    [Key]
    public int BlogGalleryId { get; set; }
    public int BlogId { get; set; }
    public string ImageName { get; set; }
    public string ImageTitle { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Blog Blog { get; set; }
}
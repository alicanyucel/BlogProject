

using BlogProject.Domain.Abstract;


namespace BlogProject.Domain;
public class Comment :Entity, IEntity
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Message { get; set; }
    public string? Description { get; set; }
    public string? FileName { get; set; }
    public bool Status { get; set; }
    public bool ReadStatus { get; set; }
    public int StarRating { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public DateTime? ReadCreated { get; set; }
    public Language Language { get; set; }
    public ModulCategory ModulCategory { get; set; }
}
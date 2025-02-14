

using BlogProject.Domain.Abstract;
using BlogProject.DomaiN;

namespace BlogProject.Domain;
public class City :Entity, IEntity
{
    public string? Name { get; set; }
    public string? Flag { get; set; }
    public bool? Status { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Country Country { get; set; }
    public State State { get; set; }
}
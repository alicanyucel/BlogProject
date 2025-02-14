

using BlogProject.Domain.Abstract;
using BlogProject.DomaiN;

namespace BlogProject.Domain;
public class Patient :Entity, IEntity
{
	public string? Gender { get; set; }
	public string? PhoneNumber { get; set; }
	public string? BloodGroup { get; set; }
	public string? Address { get; set; }
	public string? ZipCode { get; set; }
	public bool? Status { get; set; }
	public string? ImageName { get; set; }
	public string? CreatedBy { get; set; }
	public DateTime? Created { get; set; }
	public string? ModifiedBy { get; set; }
	public DateTime? Modified { get; set; }
	public AppUser AppUser { get; set; }
	public Country Country { get; set; }
	public City City { get; set; }
	public State State { get; set; }
}
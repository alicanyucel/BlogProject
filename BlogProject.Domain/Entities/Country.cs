

using BlogProject.Domain.Abstract;
using BlogProject.DomaiN;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class Country : IEntity
{

    [Key]
    public int CountryId { get; set; }
    public int? LanguageId { get; set; }
    public string? Name { get; set; }
    public string? Iso3 { get; set; }
    public string? Iso2 { get; set; }
    public string? PhoneCode { get; set; }
    public string? Capital { get; set; }
    public string? Currency { get; set; }
    public string? Flag { get; set; }
    public bool? Status { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Language Language { get; set; }
    public List<Patient> Patients { get; set; }
    public List<State> States { get; set; }
    public List<City> Cities { get; set; }
}
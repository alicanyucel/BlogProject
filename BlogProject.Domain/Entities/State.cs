
using BlogProject.Domain;
using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;


public class State : IEntity
{
    [Key]
    public int StateId { get; set; }
    public int? CountryId { get; set; }
    public string? Name { get; set; }
    public string? Flag { get; set; }
    public bool? Status { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public Country Country { get; set; }
    public string TestField { get; set; }


}


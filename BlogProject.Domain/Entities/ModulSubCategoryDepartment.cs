using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class ModulSubCategoryDepartment : IEntity
{
	[Key]
	public int ModulSubCategoryDepartmentId { get; set; }
	public int? ModulSubCategoryId { get; set; }
	public int? DepartmentId { get; set; }
	public string? CreatedBy { get; set; }
	public DateTime? Created { get; set; }
	public string? ModifiedBy { get; set; }
	public DateTime? Modified { get; set; }
	public ModulSubCategory ModulSubCategory { get; set; }
	public Department Department { get; set; }

}
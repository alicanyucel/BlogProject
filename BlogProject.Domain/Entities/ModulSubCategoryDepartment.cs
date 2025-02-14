using BlogProject.Domain.Abstract;

namespace BlogProject.Domain;
public class ModulSubCategoryDepartment :Entity, IEntity
{
	public string? CreatedBy { get; set; }
	public DateTime? Created { get; set; }
	public string? ModifiedBy { get; set; }
	public DateTime? Modified { get; set; }
	public ModulSubCategory ModulSubCategory { get; set; }
	public Department Department { get; set; }
}
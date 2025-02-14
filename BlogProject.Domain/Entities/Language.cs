

using BlogProject.Domain.Abstract;
using BlogProject.DomaiN;

namespace BlogProject.Domain;

public class Language :Entity, IEntity
{
    public int RowNumber { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }
    public string? ImageName { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public List<Department> Departments { get; set; }
    public List<Speciality> Specialities { get; set; }
    public List<AcademicTitle> AcademicTitles { get; set; }
    public List<Blog> Blogs { get; set; }
    public List<BlogCategory> BlogCategories { get; set; }
    public List<Slider> Sliders { get; set; }
    public List<Footer> Footers { get; set; }
    public List<MenuCategory> MenuCategories { get; set; }
    public List<Gender> Genders { get; set; }
    public List<Contact> Contacts { get; set; }
    public List<ContactFormSubject> ContactFormSubjects { get; set; }
    public List<ContactForm> ContactForms { get; set; }
    public List<Treatment> Treatments { get; set; }
    public List<TreatmentCategory> TreatmentCategories { get; set; }
    public List<Comment> Comments { get; set; }
    public List<ModulCategory> ModulCategories { get; set; }
    public List<ModulSubCategory> ModulSubCategories { get; set; }
}

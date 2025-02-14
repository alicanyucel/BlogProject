
using BlogProject.Domain;
using GenericRepository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BlogProject.DomaiN;
using BlogProject.Domai;

namespace BlogProject.Infrastructure.DataContext;

public sealed class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    DbSet<Slider> Sliders { get; set; }
    DbSet<Blog> Blogs { get; set; }
    DbSet<BlogCategory> BlogCategories { get; set; }
    DbSet<BlogGallery> BlogGalleries { get; set; }
    DbSet<BlogVideo> BlogVideos { get; set; }
    DbSet<City> Cities { get; set; }
    DbSet<Comment> Comments { get; set; }
    DbSet<Contact> Contacts { get; set; }
    DbSet<ContactForm> ContactForms { get; set; }
    DbSet<ContactFormSubject> ContactFormsSubjects { get; set; }
    DbSet<Country> Countries { get; set; }
    DbSet<Department> Departments { get; set; }
    DbSet<Doctor> Doctors { get; set; }
    DbSet<DoctorDepartment> DoctorDepartments { get; set; }
    DbSet<DoctorGallery> DoctorGalleries { get; set; }
    DbSet<DoctorSpeciality> DoctorSpecialities { get; set; }
    DbSet<DoctorSpokenLanguage> DoctorSpokenLanguages { get; set; }
    DbSet<DoctorTreatment> DoctorTreatments { get; set; }
    DbSet<Footer> Footers { get; set; }
    DbSet<Language> Languages { get; set; }
    DbSet<Gender> Genders { get; set; }
    DbSet<MenuCategory> MenuCategories { get; set; }
    DbSet<MenuSubCategory> MenuSubCategories { get; set; }
    DbSet<Modul> Moduls { get; set; }
    DbSet<ModulCategory> ModulCategories {  get; set; } 
    DbSet<ModulSubCategory> ModulSubCategories { get; set; }
    DbSet<ModulSubCategoryDepartment> ModulSubCategoryDepartments { get; set; }
    DbSet<Patient> Patients { get; set; }
    DbSet<SeoSetting> SeoSettings { get; set; }
    DbSet<Speciality> Specializations { get; set; }
    DbSet<SpokenLanguage> SpokenLanguages { get; set; }
    DbSet<State> States { get; set; }
    DbSet<TechnologicalDevice> TechnologicalDevices { get; set; }
    DbSet<TechnologicalDeviceDepartment> TechnologicalDevicesDepartment { get; set; }
    DbSet<Treatment> Treatments {  get; set; }
    DbSet<TreatmentCategory> treatmentCategories { get; set; }
    

    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.ApplyConfigurationsFromAssembly(typeof(DependencyInjection).Assembly);
        // istenmeyen identity tablolar
        builder.Ignore<IdentityUserLogin<Guid>>();
        builder.Ignore<IdentityRoleClaim<Guid>>();
        builder.Ignore<IdentityUserToken<Guid>>();
        builder.Ignore<IdentityUserRole<Guid>>();
        builder.Ignore<IdentityUserClaim<Guid>>();
    }
}
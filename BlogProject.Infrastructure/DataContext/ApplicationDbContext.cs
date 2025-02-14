
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
    DbSet<ModulCategory> ModulCategories { get; set; }
    DbSet<ModulSubCategory> ModulSubCategories { get; set; }
    DbSet<ModulSubCategoryDepartment> ModulSubCategoryDepartments { get; set; }
    DbSet<Patient> Patients { get; set; }
    DbSet<SeoSetting> SeoSettings { get; set; }
    DbSet<Speciality> Specializations { get; set; }
    DbSet<SpokenLanguage> SpokenLanguages { get; set; }
    DbSet<State> States { get; set; }
    DbSet<TechnologicalDevice> TechnologicalDevices { get; set; }
    DbSet<TechnologicalDeviceDepartment> TechnologicalDevicesDepartment { get; set; }
    DbSet<Treatment> Treatments { get; set; }
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
        // Department ilişkisi için cascade delete'yi devre dışı bırak
        builder.Entity<Speciality>()
            .HasOne(s => s.Department)
            .WithMany()  // Birden fazla speciality olabilir
            .HasForeignKey(s => s.DepartmentId)
            .OnDelete(DeleteBehavior.NoAction); // Cascade delete devre dışı bırakılıyor

        // Language ilişkisi için cascade delete'yi devre dışı bırak
        builder.Entity<Speciality>()
            .HasOne(s => s.Language)
            .WithMany()  // Birden fazla speciality olabilir
            .HasForeignKey(s => s.LanguageId)
            .OnDelete(DeleteBehavior.NoAction); // Cascade delete devre dışı bırakılıyor
        builder.Entity<Treatment>()
            .HasOne(t => t.Language)
            .WithMany() // Birden fazla Treatment olabilir
            .HasForeignKey(t => t.LanguageId)
            .OnDelete(DeleteBehavior.NoAction);  // Cascade delete devre dışı bırak

        // Department ile olan ilişkiyi yapılandır
        builder.Entity<Treatment>()
            .HasOne(t => t.Department)
            .WithMany() // Birden fazla Treatment olabilir
            .HasForeignKey(t => t.DepartmentId)
            .OnDelete(DeleteBehavior.NoAction);  // Cascade delete devre dışı bırak

        // TreatmentCategory ile olan ilişkiyi yapılandır
        builder.Entity<Treatment>()
            .HasOne(t => t.TreatmentCategory)
            .WithMany() // Birden fazla Treatment olabilir
            .HasForeignKey(t => t.TreatmentCategoryId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.Entity<ModulCategory>()
            .HasOne(m => m.Language)
            .WithMany() // Language birden fazla ModulCategory'yi barındırabilir
            .HasForeignKey(m => m.LanguageId)
            .OnDelete(DeleteBehavior.NoAction);  // Cascade delete devre dışı bırak

        // Modul ile olan ilişkiyi yapılandır
        builder.Entity<ModulCategory>()
            .HasOne(m => m.Modul)
            .WithMany() // Modul birden fazla ModulCategory'yi barındırabilir
            .HasForeignKey(m => m.ModulId)
            .OnDelete(DeleteBehavior.NoAction);  // Cascade delete devre dışı bırak

        // ModulSubCategory ile olan ilişkiyi yapılandır
        builder.Entity<ModulCategory>()
            .HasMany(m => m.ModulSubCategory)
            .WithOne() // ModulSubCategory birden fazla ModulCategory'yi barındırabilir
            .OnDelete(DeleteBehavior.NoAction);  // Cascade delete devre dışı bırak

        // Comment ile olan ilişkiyi yapılandır
        builder.Entity<ModulCategory>()
            .HasMany(m => m.Comment)
            .WithOne() // Comment birden fazla ModulCategory'yi barındırabilir
            .OnDelete(DeleteBehavior.NoAction);  // Cascade delete devre dışı bırak
        builder.Entity<Comment>()
           .HasOne(c => c.Language)
           .WithMany() // Language birden fazla Comment'i barındırabilir
           .HasForeignKey(c => c.LanguageId)
           .OnDelete(DeleteBehavior.NoAction);  // Cascade delete devre dışı bırak

        // ModulCategory ile olan ilişkiyi yapılandır
        builder.Entity<Comment>()
            .HasOne(c => c.ModulCategory)
            .WithMany() // ModulCategory birden fazla Comment'i barındırabilir
            .HasForeignKey(c => c.ModulCategoryId)
            .OnDelete(DeleteBehavior.NoAction);  // Cascade delete devre dışı bırak
        builder.Entity<City>()
            .HasOne(c => c.Country)
            .WithMany() // Country birden fazla City'i barındırabilir
            .HasForeignKey(c => c.CountryId)
            .OnDelete(DeleteBehavior.NoAction);  // Cascade delete devre dışı bırak

        // State ile olan ilişkiyi yapılandır
        builder.Entity<City>()
             .HasOne(c => c.State)
             .WithMany() // State birden fazla City'i barındırabilir
             .HasForeignKey(c => c.StateId)
             .OnDelete(DeleteBehavior.NoAction);  // Cascade delete devre dışı bırak
                                                  // doctor
        builder.Entity<Doctor>()
           .HasOne(d => d.AppUser)
           .WithMany()
           .HasForeignKey(d => d.AppUserId)
           .OnDelete(DeleteBehavior.NoAction);

        // Language ile ilişkiyi yapılandır
        builder.Entity<Doctor>().HasOne(d => d.Language)
             .WithMany()
             .HasForeignKey(d => d.LanguageId)
             .OnDelete(DeleteBehavior.NoAction);

        // AcademicTitle ile ilişkiyi yapılandır
        builder.Entity<Doctor>()
            .HasOne(d => d.AcademicTitle)
            .WithMany()
            .HasForeignKey(d => d.AcademicTitleId)
            .OnDelete(DeleteBehavior.NoAction);

        // Gender ile ilişkiyi yapılandır
        builder.Entity<Doctor>()
            .HasOne(d => d.Gender)
            .WithMany()
            .HasForeignKey(d => d.GenderId)
            .OnDelete(DeleteBehavior.NoAction);

        // Country ile ilişkiyi yapılandır
        builder.Entity<Doctor>()
            .HasOne(d => d.Country)
            .WithMany()
            .HasForeignKey(d => d.CountryId)
            .OnDelete(DeleteBehavior.NoAction);

        // City ile ilişkiyi yapılandır
        builder.Entity<Doctor>()
            .HasOne(d => d.City)
            .WithMany()
            .HasForeignKey(d => d.CityId)
            .OnDelete(DeleteBehavior.NoAction);

        // State ile ilişkiyi yapılandır
        builder.Entity<Doctor>()
            .HasOne(d => d.State)
            .WithMany()
            .HasForeignKey(d => d.StateId)
            .OnDelete(DeleteBehavior.NoAction);

        // Department ile ilişkiyi yapılandır
        builder.Entity<Doctor>()
            .HasOne(d => d.Department)
            .WithMany()
            .HasForeignKey(d => d.DepartmentId)
            .OnDelete(DeleteBehavior.NoAction);

        // Speciality ile ilişkiyi yapılandır
        builder.Entity<Doctor>()
            .HasOne(d => d.Speciality)
            .WithMany()
            .HasForeignKey(d => d.SpecialityId)
            .OnDelete(DeleteBehavior.NoAction);

        // TreatmentCategory ile ilişkiyi yapılandır
        builder.Entity<Doctor>()
            .HasOne(d => d.TreatmentCategory)
            .WithMany()
            .HasForeignKey(d => d.TreatmentCategoryId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.Entity<Blog>()
            .HasOne(b => b.Language)
            .WithMany()
            .HasForeignKey(b => b.LanguageId)
            .OnDelete(DeleteBehavior.Cascade);

        // Blog ile BlogCategory ilişkisi
        builder.Entity<Blog>()
            .HasOne(b => b.BlogCategory)
            .WithMany()
            .HasForeignKey(b => b.BlogCategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        // Blog ile AppUser ilişkisi
        builder.Entity<Blog>()
            .HasOne(b => b.AppUser)
            .WithMany()
            .HasForeignKey(b => b.AppUserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Blog ile Department ilişkisi
        builder.Entity<Blog>()
            .HasOne(b => b.Department)
            .WithMany()
            .HasForeignKey(b => b.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);

        // Blog ile Speciality ilişkisi
        builder.Entity<Blog>()
            .HasOne(b => b.Speciality)
            .WithMany()
            .HasForeignKey(b => b.SpecialityId)
            .OnDelete(DeleteBehavior.Cascade);

        // Blog ile BlogGallery ilişkisi
        builder.Entity<Blog>()
            .HasMany(b => b.BlogGalleries)
            .WithOne(bg => bg.Blog)
            .HasForeignKey(bg => bg.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
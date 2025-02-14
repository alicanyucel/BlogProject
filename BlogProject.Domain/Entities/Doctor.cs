using BlogProject.Domai;
using BlogProject.Domain.Abstract;
using BlogProject.DomaiN;

namespace BlogProject.Domain;
public class Doctor : Entity, IEntity
{
    public int RowNumber { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Description { get; set; }
    public string? Address { get; set; }
    public string? ZipCode { get; set; }
    public bool Status { get; set; }
    public bool HomePageStatus { get; set; }
    public string? ImageName { get; set; }
    public string? RegistrationNumber { get; set; }
    public DateTime? Birthday { get; set; }
    public DateTime? StartCareerYear { get; set; }
    public string? AboutMe { get; set; }
    public string? Education { get; set; }
    public string? Experience { get; set; }
    public string? Interests { get; set; }
    public string? Memberships { get; set; }
    public string? Awards { get; set; }
    public string? Certificates { get; set; }
    public string? Articles { get; set; }
    public bool Pricing { get; set; }
    public int Price { get; set; }
    public string? InstagramLink { get; set; }
    public string? FacebookLink { get; set; }
    public string? TwitterLink { get; set; }
    public string? YoutubeLink { get; set; }
    public string? LinkedinLink { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
    public DateTime? LastLogined { get; set; }

    // Foreign Key Tanımlamaları
    public Guid AppUserId { get; set; }
    public AppUser AppUser { get; set; }

    public Guid LanguageId { get; set; }
    public Language Language { get; set; }

    public Guid AcademicTitleId { get; set; }
    public AcademicTitle AcademicTitle { get; set; }

    public Guid GenderId { get; set; }
    public Gender Gender { get; set; }

    public Guid CountryId { get; set; }
    public Country Country { get; set; }

    public Guid CityId { get; set; }
    public City City { get; set; }

    public Guid StateId { get; set; }
    public State State { get; set; }

    public Guid DepartmentId { get; set; }
    public Department Department { get; set; }

    public Guid SpecialityId { get; set; }
    public Speciality Speciality { get; set; }

    public Guid TreatmentCategoryId { get; set; }
    public TreatmentCategory TreatmentCategory { get; set; }

    // Birçoktan Bire ve Birçoktan Çoğa İlişkiler
    public ICollection<DoctorDepartment> DoctorDepartments { get; set; }
    public List<DoctorSpeciality> DoctorSpecialities { get; set; }
    public List<DoctorTreatment> DoctorTreatments { get; set; }
    public List<DoctorSpokenLanguage> DoctorSpokenLanguages { get; set; }
    public List<DoctorGallery> DoctorGalleries { get; set; }
}

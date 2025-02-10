

using Microsoft.AspNetCore.Identity;

namespace BlogProject.Domain;
public class AppUser : IdentityUser<int>
{
    public int? LanguageId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Districht { get; set; }
    public string City { get; set; }
    public string ImageName { get; set; }
    public string? ConfirmCode { get; set; }
    public bool? UserStatus { get; set; }
    public string? UserType { get; set; }

    //public List<User> Users { get; set; }        
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }
    public List<Blog> Blogs { get; set; }
    public Language Language { get; set; }

}

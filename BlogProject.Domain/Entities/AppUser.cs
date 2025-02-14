

using Microsoft.AspNetCore.Identity;

namespace BlogProject.Domain;
public class AppUser : IdentityUser<Guid>
{
    public int? LanguageId { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string FullName => string.Join(" ", FirstName, Surname);
    public string Districht { get; set; }
    public string City { get; set; }
    public string ImageName { get; set; }
    public string? ConfirmCode { get; set; }
    public bool? UserStatus { get; set; }
    public string? UserType { get; set; }

    //public List<User> Users { get; set; }      
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpires { get; set; }
}

using BlogProject.Domain;
using Microsoft.AspNetCore.Identity;

namespace BlogProject.WebApi.Middleware
{
    public static class ExtensionsMiddleware
    {
        public static void CreateFirstUser(WebApplication app)
        {
            using (var scoped = app.Services.CreateScope())
            {
                var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

                if (!userManager.Users.Any(p => p.UserName == "admin"))
                {
                    // migration atıldıgı zaman kullanıcı default olustur
                    AppUser user = new()
                    {
                        UserName = "admin",
                        Email = "admin@admin.com",
                        FirstName = "Ali Can",
                        Surname = "Yücel",
                        EmailConfirmed = true
                    };
                    // usernbame=admin
                    //password=1
                    userManager.CreateAsync(user, "1").Wait();
                }
            }
        }
    }
}


using BlogProject.Domain;
using GenericRepository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Infrastructure.DataContext;

public sealed class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    


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
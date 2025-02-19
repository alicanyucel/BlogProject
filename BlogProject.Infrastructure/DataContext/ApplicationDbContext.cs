
using BlogProject.Domain;
using GenericRepository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BlogProject.Domain.Entities;

namespace BlogProject.Infrastructure.DataContext;

public sealed class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
     public DbSet<Slider> Sliders { get; set; }
     public DbSet<Language> Languages { get; set; }
  

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
using BlogProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BlogProject.Infrastructure.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.ToTable("Sliders");

            builder.HasKey(s => s.SliderId);

            builder.Property(s => s.RowNumber)
                .IsRequired();

            builder.Property(s => s.Name)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(s => s.Title)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(s => s.Description)
                .HasMaxLength(1000)
                .IsRequired(false);

            builder.Property(s => s.Status)
                .IsRequired();

            builder.Property(s => s.ImageName)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(s => s.ImageNameMobile)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(s => s.ClickCount)
                .IsRequired();

            builder.Property(s => s.NoIndex)
                .IsRequired();

            builder.Property(s => s.IsLink)
                .IsRequired();

            builder.Property(s => s.LinkUrl)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(s => s.LinkOut)
                .IsRequired();

            builder.Property(s => s.SeoTitle)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(s => s.SeoDescription)
                .HasMaxLength(1000)
                .IsRequired(false);

            builder.Property(s => s.SeoKeyword)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(s => s.CreatedBy)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(s => s.Created)
                .IsRequired(false);

            builder.Property(s => s.ModifiedBy)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(s => s.Modified)
                .IsRequired(false);

            builder.HasOne(s => s.Language)
                .WithMany()
                .HasForeignKey(s => s.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

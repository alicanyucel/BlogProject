
namespace BlogProject.Infrastructure.Configurations
{
    using BlogProject.Domain;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            // LanguageId'yi ana anahtar (primary key) olarak belirleyelim
            builder.HasKey(e => e.LanguageId);

            // RowNumber'ı zorunlu hale getirelim
            builder.Property(e => e.RowNumber)
                .IsRequired();

            // Sliders ile olan ilişkiyi belirleyelim
            builder.HasMany(e => e.Sliders)
                .WithOne() // Sliders tablosunda, Language ile olan ilişkiyi tek yönlü belirtiyoruz
                .HasForeignKey(s => s.LanguageId); // Sliders tablosunda LanguageId dış anahtarını belirliyoruz
        }
    }

}

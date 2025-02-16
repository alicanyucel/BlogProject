
using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class Language : IEntity
{
    [Key]
    public Guid LanguageId { get; set; }
    public Guid RowNumber { get; set; }
    public List<Slider> Sliders { get; set; } // bu değerler language tablosunda gozukmeyecektir sadece ilşkili olduugnu soyluyor


}
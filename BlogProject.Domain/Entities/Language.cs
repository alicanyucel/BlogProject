
using BlogProject.Domain.Abstract;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class Language : IEntity
    {
        public int LanguageId { get;init; } // Primary Key
        public int RowNumber { get; set; } // Diğer bilgiler
    // Sliders tablosu ile ilişki
    public List<Slider> Sliders { get; set; } // Foreign key ile ilişkili
    }

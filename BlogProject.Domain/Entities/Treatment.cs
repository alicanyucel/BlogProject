﻿
using BlogProject.Domain.Abstract;
namespace BlogProject.Domain;
public class Treatment : Entity, IEntity
{
    public int RowNumber { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? OperationInformation { get; set; }
    public bool Status { get; set; }
    public bool ShowHomePage { get; set; }
    public int HomePageOrder { get; set; }
    public string? ImageName { get; set; }
    public string? ImageNameDetail { get; set; }
    public int ClickCount { get; set; }
    public bool NoIndex { get; set; }
    public string? SeoTitle { get; set; }
    public string? SeoDescription { get; set; }
    public string? SeoKeyword { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }

    // Foreign Key'ler
    public Guid LanguageId { get; set; }
    public Language Language { get; set; }

    public Guid DepartmentId { get; set; }
    public Department Department { get; set; }

    public Guid TreatmentCategoryId { get; set; }
    public TreatmentCategory TreatmentCategory { get; set; }

    // Doctors ilişkisi (şu an kullanılmıyor)
    // public List<Doctor> Doctors { get; set; }
}

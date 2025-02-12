﻿
using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class BlogVideo : IEntity
{
	[Key]
	public int BlogVideoId { get; set; }
	public int? LanguageId { get; set; }
	public int BlogCategoryId { get; set; }
	public int? AppUserId { get; set; }
	public int? DepartmentId { get; set; }
	public int? SpecialityId { get; set; }
	public int RowNumber { get; set; }
	public string? Name { get; set; }
	public string? Title { get; set; }
	public string? ShortDescription { get; set; }
	public string? Description { get; set; }
	public bool Status { get; set; }
	public string? ImageName { get; set; }
	public int ClickCount { get; set; }
	public bool NoIndex { get; set; }
	public bool IsLink { get; set; }
	public string? LinkUrl { get; set; }
	public bool LinkOut { get; set; }
	public string? VideoUrl { get; set; }
	public string? ReadingTime { get; set; }
	public string? SeoTitle { get; set; }
	public string? SeoDescription { get; set; }
	public string? SeoKeyword { get; set; }
	public string? CreatedBy { get; set; }
	public DateTime? Created { get; set; }
	public string? ModifiedBy { get; set; }
	public DateTime? Modified { get; set; }
	public Language Language { get; set; }
	public BlogCategory BlogCategory { get; set; }
	public AppUser AppUser { get; set; }
	public Department Department { get; set; }
	public Speciality Speciality { get; set; }

}

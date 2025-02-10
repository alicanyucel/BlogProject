﻿

using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain;
public class BlogCategory : IEntity
{
	[Key]
	public int BlogCategoryId { get; set; }
	public int LanguageId { get; set; }
	public int RowNumber { get; set; }
	public string? Name { get; set; }
	public string? Title { get; set; }
	public string? Description { get; set; }
	public bool Status { get; set; }
	public string? ImageName { get; set; }
	public int ClickCount { get; set; }
	public bool NoIndex { get; set; }
	public string? SeoTitle { get; set; }
	public string? SeoDescription { get; set; }
	public string? SeoKeyword { get; set; }
	public string? CreatedBy { get; set; }
	public DateTime? Created { get; set; }
	public string? ModifiedBy { get; set; }
	public DateTime? Modified { get; set; }
	public Language Language { get; set; }
	public List<Blog> Blogs { get; set; }
	public List<BlogVideo> BlogVideos { get; set; }

}

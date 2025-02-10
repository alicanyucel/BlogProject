﻿

using BlogProject.Domain.Abstract;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Speciality : IEntity
    {
		[Key]
		public int SpecialityId { get; set; }
		public int? LanguageId { get; set; }
		public int DepartmentId { get; set; }
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
        public Department Department { get; set; }
        public Language Language { get; set; }
        public List<Doctor> Doctors { get; set; }

    }
}

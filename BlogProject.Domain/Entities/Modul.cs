﻿

using BlogProject.Domain.Abstract;

namespace BlogProject.Domain;
public class Modul:Entity, IEntity
{
    public int RowNumber { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }
    public string? ImageName { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? Created { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime? Modified { get; set; }
}

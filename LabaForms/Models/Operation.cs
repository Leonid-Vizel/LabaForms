using System.ComponentModel.DataAnnotations;

namespace LabaForms.Models;

public sealed class Operation
{
    [Key]
    public int Id { get; set; }
    public Part Part { get; set; } = null!;
    public int PartId { get; set; }
    public Material Material { get; set; } = null!;
    public int MaterialId { get; set; }
    public decimal NeededAmount { get; set; }
    public List<Norm> Norms { get; set; } = null!;
}

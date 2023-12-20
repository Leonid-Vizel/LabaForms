using System.ComponentModel.DataAnnotations;
using Weasel.Tools.Extensions.Common;

namespace LabaForms.Models;

public sealed class Part
{
    [Key]
    public int Id { get; set; }
    public DetailType DetailType { get; set; }
    [MaxLength(2000)]
    public string Name { get; set; } = null!;
    [MaxLength(500)]
    public string Measurement { get; set; } = null!;
    public decimal PlanPrice { get; set; }
    public string? DetailTypeName
        => DetailType.GetDisplayName();
    public List<Norm> Norms { get; set; } = null!;
    public List<Operation> Operations { get; set; } = null!;
}

public enum DetailType
{
    [Display(Name = "Простая деталь")]
    Simple,
    [Display(Name = "Сложная деталь")]
    Complex
}

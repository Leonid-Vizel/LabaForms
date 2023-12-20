using System.ComponentModel.DataAnnotations;

namespace LabaForms.Models;

public sealed class Material
{
    [Key]
    public int Id { get; set; }
    [MaxLength(1000)]
    public string Name { get; set; } = null!;
    [MaxLength(100)]
    public string Measurement { get; set; } = null!;
    public decimal? PlanPrice { get; set; }
    public List<Operation> Operations { get; set; } = null!;
}

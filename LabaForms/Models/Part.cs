using System.ComponentModel.DataAnnotations;

namespace LabaForms.Models;

public sealed class Part
{
    [Key]
    public int Id { get; set; }
    public int DetailType { get; set; } //enum is needed here, but IDGAF
    [MaxLength(2000)]
    public string Name { get; set; } = null!;
    [MaxLength(500)]
    public string Measurement { get; set; } = null!;
    public decimal PlanPrice { get; set; }
    public List<Norm> Norms { get; set; } = null!;
    public List<Operation> Operations { get; set; } = null!;
}

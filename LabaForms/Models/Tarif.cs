using System.ComponentModel.DataAnnotations;

namespace LabaForms.Models;

public sealed class Tarif
{
    [Key]
    public int Id { get; set; }
    public decimal PerHour { get; set; }
    public List<Norm> Norms { get; set; } = null!;
}

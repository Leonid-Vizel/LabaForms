using System.ComponentModel.DataAnnotations;

namespace LabaForms.Models;

public sealed class Profession
{
    [Key]
    public int Id { get; set; }
    [MaxLength(1000)]
    public string Name { get; set; } = null!;
    public List<Norm> Norms { get; set; } = null!;

    public override string ToString()
        => $"[ИД:{Id}] {Name}";
}

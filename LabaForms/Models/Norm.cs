using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LabaForms.Models;

[PrimaryKey(nameof(PartId), nameof(OperationId))]
public sealed class Norm
{
    public Part Part { get; set; } = null!;
    public int PartId { get; set; }
    public Operation Operation { get; set; } = null!;
    public int OperationId { get; set; }
    public Profession Profession { get; set; } = null!;
    public int ProfessionId { get; set; }
    public Tarif Tarif { get; set; } = null!;
    public int TarifId { get; set; }
    [MaxLength(2000)]
    public string Qualification { get; set; } = null!;
    public decimal FinalMinuteTime { get; set; }
    public decimal PieceMinuteTime { get; set; }
}

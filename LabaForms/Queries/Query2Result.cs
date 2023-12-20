namespace LabaForms.Queries;

public sealed class Query2Result
{
    public static readonly string Query = "SELECT p.\"Id\",\r\nROUND(SUM(n.\"FinalMinuteTime\" / 60.0 * t.\"PerHour\"), 1) as \"FinalWorkPrice\",\r\nROUND(SUM(m.\"PlanPrice\" * o.\"NeededAmount\"), 1) as \"MaterialPrice\"\r\nFROM \"Parts\" AS p\r\nINNER JOIN \"Norms\" AS n ON n.\"PartId\" = p.\"Id\"\r\nINNER JOIN \"Tarifs\" AS t ON n.\"TarifId\" = t.\"Id\"\r\nINNER JOIN \"Operations\" AS o ON n.\"OperationId\" = o.\"Id\"\r\nINNER JOIN \"Materials\" AS m ON o.\"MaterialId\" = m.\"Id\"\r\nGROUP BY p.\"Id\";";

    public int Id { get; set; }
    public decimal FinalWorkPrice { get; set; }
    public decimal MaterialPrice { get; set; }
}

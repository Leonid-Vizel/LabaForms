namespace LabaForms.Queries;

public sealed class Query1Result
{
    public static readonly string Query = "SELECT n.\"PartId\", n.\"OperationId\", n.\"ProfessionId\", t.\"PerHour\" AS \"TarifPerHour\"\r\nFROM \"Norms\" AS n\r\nINNER JOIN \"Tarifs\" AS t ON n.\"TarifId\" = t.\"Id\"\r\nWHERE n.\"ProfessionId\" = 1;";
    
    public int PartId { get; set; }
    public int OperationId { get; set; }
    public int ProfessionId { get; set; }
    public decimal TarifPerHour { get; set; }
}

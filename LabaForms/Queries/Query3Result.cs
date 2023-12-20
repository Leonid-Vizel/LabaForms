namespace LabaForms.Queries;

public sealed class Query3Result
{
    public static readonly string Query = "SELECT p.\"Id\", p.\"Name\" FROM \"Professions\" as p\r\nWHERE NOT EXISTS (\r\n    SELECT \"Id\"\r\n    FROM \"Tarifs\" as t\r\n    WHERE NOT EXISTS (\r\n        SELECT \"Id\"\r\n        FROM \"Norms\" n\r\n        WHERE n.\"ProfessionId\" = p.\"Id\" AND n.\"TarifId\" = t.\"Id\"\r\n    )\r\n);";

    public int Id { get; set; }
    public string Name { get; set; } = null!;
}

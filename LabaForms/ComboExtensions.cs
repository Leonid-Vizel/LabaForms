using Weasel.Tools.Extensions.Common;

namespace LabaForms;

public class StandardComboItem<T>
{
    public T Data { get; set; }
    public string? Name { get; set; }
    public StandardComboItem(T data)
    {
        Data = data;
    }
    public override string ToString()
        => Name ?? "";
}

public sealed class EnumComboItem<T> : StandardComboItem<T> where T : Enum
{
    public EnumComboItem(T data) : base(data)
    {
        Name = data.GetDisplayName();
    }
}

public static class ComboExtensions
{
    public static List<EnumComboItem<T>> GetEnumComboItems<T>() where T : Enum
        => Enum.GetValues(typeof(T)).Cast<T>().Select(x => new EnumComboItem<T>(x)).ToList();
}
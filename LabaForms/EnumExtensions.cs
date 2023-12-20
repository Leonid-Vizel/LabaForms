using Weasel.Tools.Extensions.Common;

namespace LabaForms;

public sealed class EnumComboItem<T> where T : Enum
{
    public T Data { get; set; }
    public string? Name { get; set; }
    public EnumComboItem(T data)
    {
        Data = data;
        Name = data.GetDisplayName();
    }
    public override string ToString()
        => Name ?? "";
}

public static class EnumExtensions
{
    public static List<EnumComboItem<T>> GetComboItems<T>() where T : Enum
        => Enum.GetValues(typeof(T)).Cast<T>().Select(x => new EnumComboItem<T>(x)).ToList();
}
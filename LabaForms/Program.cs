namespace LabaForms;

internal static class Program
{
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MenuForm());
    }
}

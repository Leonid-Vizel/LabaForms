using LabaForms.Data;

namespace LabaForms;

public partial class OperationsForm : Form, IDisposable
{
    private readonly ApplicationDbContext _context;
    public OperationsForm()
    {
        _context = new ApplicationDbContext();
        InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (components != null)
            {
                components.Dispose();
            }
            _context.Dispose();
        }
        base.Dispose(disposing);
    }
}

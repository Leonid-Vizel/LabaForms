using LabaForms.Data;

namespace LabaForms;

public partial class NormsForm : Form, IDisposable
{
    private readonly ApplicationDbContext _context;
    public NormsForm()
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

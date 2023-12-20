using LabaForms.Data;

namespace LabaForms;

public partial class QueriesForm : Form, IDisposable
{
    private readonly ApplicationDbContext _context;
    public QueriesForm()
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

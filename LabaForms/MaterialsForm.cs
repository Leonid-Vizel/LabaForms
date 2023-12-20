using LabaForms.Data;

namespace LabaForms.Materials;

public partial class MaterialsForm : Form, IDisposable
{
    private readonly ApplicationDbContext _context;
    public MaterialsForm()
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

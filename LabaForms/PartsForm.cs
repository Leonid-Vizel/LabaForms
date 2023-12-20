﻿using LabaForms.Data;

namespace LabaForms;

public partial class PartsForm : Form, IDisposable
{
    private readonly ApplicationDbContext _context;
    public PartsForm()
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

﻿using LabaForms.Data;
using LabaForms.Queries;
using Microsoft.EntityFrameworkCore;

namespace LabaForms;

public partial class Query3Form : Form, IDisposable
{
    private readonly ApplicationDbContext _context;
    public Query3Form()
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

    private async void OnLoad(object sender, EventArgs e)
    {
        dataGrid.DataSource = await _context.Query3.FromSqlRaw(Query3Result.Query).AsNoTracking().ToListAsync();
    }
}

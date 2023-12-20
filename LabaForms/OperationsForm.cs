using LabaForms.Data;
using LabaForms.Models;
using Microsoft.EntityFrameworkCore;

namespace LabaForms;

public partial class OperationsForm : Form, IDisposable
{
    private readonly ApplicationDbContext _context;
    private List<Material> _materials;
    private List<Part> _parts;
    private Operation? _current = null;
    public OperationsForm()
    {
        _context = new ApplicationDbContext();
        _parts = _context.Parts.AsNoTracking().OrderBy(x => x.Id).ToList();
        _materials = _context.Materials.AsNoTracking().OrderBy(x => x.Id).ToList();
        InitializeComponent();
        materialBox.DataSource = _materials;
        partBox.DataSource = _parts;
    }

    private void ClearData()
    {
        neededAmountBox.Value = 0;
        partBox.SelectedItem = null;
        materialBox.SelectedItem = null;
        btnDelete.Enabled = false;
        btnSave.Text = "Сохранить";
        _current = null;
    }

    private async void UpdateGridAsync()
    {
        dataGrid.AutoGenerateColumns = false;
        var data = await _context.Operations.AsNoTracking().OrderBy(x => x.Id).ToListAsync();
        dataGrid.DataSource = data;
    }

    private async void OnSaveAsync(object sender, EventArgs e)
    {
        if (partBox.SelectedIndex == -1)
        {
            return;
        }
        if (materialBox.SelectedIndex == -1)
        {
            return;
        }
        var model = _current ?? new Operation();
        model.PartId = _parts[partBox.SelectedIndex].Id;
        model.MaterialId = _materials[materialBox.SelectedIndex].Id;
        model.NeededAmount = neededAmountBox.Value;
        if (_current != null)
        {
            _context.Update(_current);
        }
        else
        {
            await _context.AddAsync(model);
        }
        await _context.SaveChangesAsync();
        ClearData();
        UpdateGridAsync();
        MessageBox.Show("Успешно сохранено!");
    }

    private async void OnGridDoubleClick(object sender, EventArgs e)
    {
        if (dataGrid.CurrentCell.RowIndex == -1)
        {
            return;
        }
        int id = Convert.ToInt32(dataGrid.CurrentRow.Cells[0].Value);
        _current = await _context.FindAsync<Operation>(id);
        if (_current == null)
        {
            return;
        }
        partBox.SelectedItem = _parts.First(x => x.Id == _current?.PartId);
        materialBox.SelectedItem = _materials.First(x => x.Id == _current?.MaterialId);
        neededAmountBox.Value = _current.NeededAmount;
        btnSave.Text = "Изменить";
        btnDelete.Enabled = true;
    }

    private void OnCancel(object sender, EventArgs e)
        => ClearData();

    private async void OnDeleteAsync(object sender, EventArgs e)
    {
        if (_current == null)
        {
            return;
        }
        var result = MessageBox.Show("Вы уверены что хотите удалить эту строку?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            _context.Remove(_current);
            await _context.SaveChangesAsync();
            ClearData();
            UpdateGridAsync();
            MessageBox.Show("Успешно удалено!");
        }
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

    private void OnLoadAsync(object sender, EventArgs e)
    {
        ClearData();
        UpdateGridAsync();
    }
}

using LabaForms.Data;
using LabaForms.Models;
using Microsoft.EntityFrameworkCore;

namespace LabaForms;

public partial class PartsForm : Form, IDisposable
{
    private readonly List<EnumComboItem<DetailType>> _comboDataSource
        = ComboExtensions.GetEnumComboItems<DetailType>();
    private readonly ApplicationDbContext _context;
    private Part? _current = null;
    public PartsForm()
    {
        _context = new ApplicationDbContext();
        InitializeComponent();
        typeBox.DataSource = _comboDataSource;
    }

    private void ClearData()
    {
        nameBox.Text = string.Empty;
        measurementBox.Text = string.Empty;
        priceBox.Value = 0;
        typeBox.SelectedIndex = -1;
        btnDelete.Enabled = false;
        btnSave.Text = "Сохранить";
        _current = null;
    }

    private async void UpdateGridAsync()
    {
        dataGrid.AutoGenerateColumns = false;
        var data = await _context.Parts.AsNoTracking().OrderBy(x => x.Id).ToListAsync();
        dataGrid.DataSource = data;
    }

    private async void OnSaveAsync(object sender, EventArgs e)
    {
        var model = _current ?? new Part();
        model.Name = nameBox.Text.Trim();
        model.Measurement = measurementBox.Text.Trim();
        model.PlanPrice = priceBox.Value;
        model.DetailType = _comboDataSource[typeBox.SelectedIndex].Data;
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
        _current = await _context.FindAsync<Part>(id);
        if (_current == null)
        {
            return;
        }
        nameBox.Text = _current?.Name;
        measurementBox.Text = _current?.Measurement;
        priceBox.Value = _current?.PlanPrice ?? 0;
        typeBox.SelectedItem = _comboDataSource.First(x => x.Data == _current?.DetailType);
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

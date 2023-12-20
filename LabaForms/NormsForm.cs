using LabaForms.Data;
using LabaForms.Models;
using Microsoft.EntityFrameworkCore;

namespace LabaForms;

public partial class NormsForm : Form, IDisposable
{
    private readonly ApplicationDbContext _context;
    private List<Profession> _professions;
    private List<Tarif> _tarifs;
    private List<Operation> _operations;
    private List<Part> _parts;
    private Norm? _current = null;
    public NormsForm()
    {
        _context = new ApplicationDbContext();
        _professions = _context.Professions.AsNoTracking().OrderBy(x => x.Id).ToList();
        _tarifs = _context.Tarifs.AsNoTracking().OrderBy(x => x.Id).ToList();
        _operations = _context.Operations.AsNoTracking().OrderBy(x=>x.Id).ToList();
        _parts = _context.Parts.AsNoTracking().OrderBy(x => x.Id).ToList();
        InitializeComponent();
        professionBox.DataSource = _professions;
        tarifBox.DataSource = _tarifs;
        operationBox.DataSource = _operations;
        partBox.DataSource = _parts;
    }

    private void ClearData()
    {
        qualificationBox.Text = string.Empty;
        pieceMinuteTimeBox.Value = 0;
        finalMinuteTimeBox.Value = 0;
        partBox.SelectedIndex = -1;
        professionBox.SelectedIndex = -1;
        tarifBox.SelectedIndex = -1;
        operationBox.SelectedIndex = -1;
        btnDelete.Enabled = false;
        btnSave.Text = "Сохранить";
        _current = null;
    }

    private async void UpdateGridAsync()
    {
        dataGrid.AutoGenerateColumns = false;
        var data = await _context.Norms.AsNoTracking().OrderBy(x => x.OperationId).ThenBy(x => x.PartId).ThenBy(x => x.ProfessionId).ThenBy(x=>x.TarifId).ToListAsync();
        dataGrid.DataSource = data;
    }

    private async void OnSaveAsync(object sender, EventArgs e)
    {
        if (partBox.SelectedIndex == -1)
        {
            return;
        }
        if (operationBox.SelectedIndex == -1)
        {
            return;
        }
        if (tarifBox.SelectedIndex == -1)
        {
            return;
        }
        if (professionBox.SelectedIndex == -1)
        {
            return;
        }
        var model = _current ?? new Norm();
        model.PartId = _parts[partBox.SelectedIndex].Id;
        model.ProfessionId = _professions[professionBox.SelectedIndex].Id;
        model.TarifId = _tarifs[tarifBox.SelectedIndex].Id;
        model.OperationId = _operations[operationBox.SelectedIndex].Id;
        model.Qualification = qualificationBox.Text.Trim();
        model.FinalMinuteTime = finalMinuteTimeBox.Value;
        model.PieceMinuteTime = pieceMinuteTimeBox.Value;
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
        int operationId = Convert.ToInt32(dataGrid.CurrentRow.Cells[0].Value);
        int partId = Convert.ToInt32(dataGrid.CurrentRow.Cells[1].Value);
        _current = await _context.FindAsync<Norm>(operationId, partId);
        if (_current == null)
        {
            return;
        }
        partBox.SelectedItem = _parts.First(x => x.Id == _current?.PartId);
        professionBox.SelectedItem = _professions.First(x => x.Id == _current?.ProfessionId);
        tarifBox.SelectedItem = _tarifs.First(x => x.Id == _current?.TarifId);
        operationBox.SelectedItem = _operations.First(x => x.Id == _current?.OperationId);
        qualificationBox.Text = _current?.Qualification;
        finalMinuteTimeBox.Value = _current?.FinalMinuteTime ?? 0;
        pieceMinuteTimeBox.Value = _current?.PieceMinuteTime ?? 0;
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

using LabaForms.Data;
using Microsoft.EntityFrameworkCore;

namespace LabaForms;

public partial class MenuForm : Form
{
    public MenuForm()
        => InitializeComponent();

    private void OnMaterialButtonClick(object sender, EventArgs e)
    {
        var form = new MaterialsForm();
        materialsButton.Enabled = false;
        form.FormClosing += (x, y) => ReEnableButton(materialsButton);
        form.Show();
    }

    private void OnPartsButtonClick(object sender, EventArgs e)
    {
        var form = new PartsForm();
        partsButton.Enabled = false;
        form.FormClosing += (x, y) => ReEnableButton(partsButton);
        form.Show();
    }

    private void OnProfessionsButtonClick(object sender, EventArgs e)
    {
        var form = new ProfessionsForm();
        professionsButton.Enabled = false;
        form.FormClosing += (x, y) => ReEnableButton(professionsButton);
        form.Show();
    }

    private void OnTarifsButtonClick(object sender, EventArgs e)
    {
        var form = new TarifsForm();
        tarifsButton.Enabled = false;
        form.FormClosing += (x, y) => ReEnableButton(tarifsButton);
        form.Show();
    }

    private void OnOperationsButtonClick(object sender, EventArgs e)
    {
        var form = new OperationsForm();
        operationsButton.Enabled = false;
        form.FormClosing += (x, y) => ReEnableButton(operationsButton);
        form.Show();
    }

    private void OnNormsButtonClick(object sender, EventArgs e)
    {
        var form = new NormsForm();
        normsButton.Enabled = false;
        form.FormClosing += (x, y) => ReEnableButton(normsButton);
        form.Show();
    }

    private void OnQuery1ButtonClick(object sender, EventArgs e)
    {
        var form = new Query1Form();
        query1Button.Enabled = false;
        form.FormClosing += (x, y) => ReEnableButton(query1Button);
        form.Show();
    }

    private void OnQuery2ButtonClick(object sender, EventArgs e)
    {
        var form = new Query2Form();
        query2Button.Enabled = false;
        form.FormClosing += (x, y) => ReEnableButton(query2Button);
        form.Show();
    }

    private void OnQuery3ButtonClick(object sender, EventArgs e)
    {
        var form = new Query3Form();
        query3Button.Enabled = false;
        form.FormClosing += (x, y) => ReEnableButton(query3Button);
        form.Show();
    }

    private void ReEnableButton(Button button)
    {
        button.Enabled = true;
        Focus();
    }

    private async void OnLoad(object sender, EventArgs e)
    {
        try
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                await context.Database.MigrateAsync();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка!", $"Доступ к базе прерван ошибкой: \n{ex.Message}.");
        }
    }
}

using LabaForms.Materials;

namespace LabaForms;

public partial class MenuForm : Form
{
    public MenuForm()
        => InitializeComponent();

    private void OnMaterialButtonClick(object sender, EventArgs e)
    {
        var form = new MaterialsForm();
        materialsButton.Enabled = false;
        form.FormClosing += (x, y) =>
            materialsButton.Enabled = true;
        form.Show();
    }

    private void OnPartsButtonClick(object sender, EventArgs e)
    {
        var form = new PartsForm();
        partsButton.Enabled = false;
        form.FormClosing += (x, y) =>
            partsButton.Enabled = true;
        form.Show();
    }

    private void OnProfessionsButtonClick(object sender, EventArgs e)
    {
        var form = new ProfessionsForm();
        professionsButton.Enabled = false;
        form.FormClosing += (x, y) =>
            professionsButton.Enabled = true;
        form.Show();
    }

    private void OnTarifsButtonClick(object sender, EventArgs e)
    {
        var form = new TarifsForm();
        tarifsButton.Enabled = false;
        form.FormClosing += (x, y) =>
            tarifsButton.Enabled = true;
        form.Show();
    }

    private void OnOperationsButtonClick(object sender, EventArgs e)
    {
        var form = new OperationsForm();
        operationsButton.Enabled = false;
        form.FormClosing += (x, y) =>
            operationsButton.Enabled = true;
        form.Show();
    }

    private void OnNormsButtonClick(object sender, EventArgs e)
    {
        var form = new NormsForm();
        normsButton.Enabled = false;
        form.FormClosing += (x, y) =>
            normsButton.Enabled = true;
        form.Show();
    }

    private void OnQueriesButtonClick(object sender, EventArgs e)
    {
        var form = new QueriesForm();
        queriesButton.Enabled = false;
        form.FormClosing += (x, y) =>
            queriesButton.Enabled = true;
        form.Show();
    }
}

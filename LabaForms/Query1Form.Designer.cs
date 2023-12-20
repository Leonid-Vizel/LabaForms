namespace LabaForms
{
    partial class Query1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(12, 12);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 24;
            dataGrid.Size = new Size(776, 426);
            dataGrid.TabIndex = 11;
            // 
            // Query1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGrid);
            Name = "Query1Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Доп. запрос 1";
            Load += OnLoad;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGrid;
    }
}
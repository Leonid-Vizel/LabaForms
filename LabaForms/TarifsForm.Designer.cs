namespace LabaForms
{
    partial class TarifsForm
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
            nameLabel = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            dataGrid = new DataGridView();
            perHourBox = new NumericUpDown();
            idColumn = new DataGridViewTextBoxColumn();
            perHourColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perHourBox).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            nameLabel.Location = new Point(12, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 19);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "В час:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(12, 47);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 51);
            btnSave.TabIndex = 6;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += OnSaveAsync;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            btnCancel.Location = new Point(252, 47);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 51);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += OnCancel;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(129, 47);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 51);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += OnDeleteAsync;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { idColumn, perHourColumn });
            dataGrid.Location = new Point(350, 15);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 24;
            dataGrid.Size = new Size(309, 377);
            dataGrid.TabIndex = 10;
            dataGrid.DoubleClick += OnGridDoubleClick;
            // 
            // perHourBox
            // 
            perHourBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            perHourBox.Location = new Point(70, 15);
            perHourBox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            perHourBox.Name = "perHourBox";
            perHourBox.Size = new Size(274, 26);
            perHourBox.TabIndex = 12;
            // 
            // idColumn
            // 
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "ИД";
            idColumn.MinimumWidth = 6;
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            idColumn.Width = 125;
            // 
            // perHourColumn
            // 
            perHourColumn.DataPropertyName = "PerHour";
            perHourColumn.HeaderText = "В час";
            perHourColumn.MinimumWidth = 6;
            perHourColumn.Name = "perHourColumn";
            perHourColumn.ReadOnly = true;
            perHourColumn.Width = 125;
            // 
            // TarifsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 415);
            Controls.Add(perHourBox);
            Controls.Add(dataGrid);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(nameLabel);
            Name = "TarifsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тарифы";
            Load += OnLoadAsync;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)perHourBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGrid;
        private NumericUpDown perHourBox;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn perHourColumn;
    }
}
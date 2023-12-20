namespace LabaForms
{
    partial class OperationsForm
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
            btnSave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            dataGrid = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            partIdColumn = new DataGridViewTextBoxColumn();
            materialIdColumn = new DataGridViewTextBoxColumn();
            neededAmountColumn = new DataGridViewTextBoxColumn();
            neededAmountBox = new NumericUpDown();
            neededAmountLabel = new Label();
            materialLabel = new Label();
            partLabel = new Label();
            materialBox = new ComboBox();
            partBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)neededAmountBox).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(12, 129);
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
            btnCancel.Location = new Point(252, 129);
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
            btnDelete.Location = new Point(129, 129);
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
            dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { IdColumn, partIdColumn, materialIdColumn, neededAmountColumn });
            dataGrid.Location = new Point(350, 15);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 24;
            dataGrid.Size = new Size(463, 377);
            dataGrid.TabIndex = 10;
            dataGrid.DoubleClick += OnGridDoubleClick;
            // 
            // IdColumn
            // 
            IdColumn.DataPropertyName = "Id";
            IdColumn.HeaderText = "ИД";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            // 
            // partIdColumn
            // 
            partIdColumn.DataPropertyName = "PartId";
            partIdColumn.HeaderText = "ИД детали";
            partIdColumn.Name = "partIdColumn";
            partIdColumn.ReadOnly = true;
            // 
            // materialIdColumn
            // 
            materialIdColumn.DataPropertyName = "MaterialId";
            materialIdColumn.HeaderText = "ИД материала";
            materialIdColumn.Name = "materialIdColumn";
            materialIdColumn.ReadOnly = true;
            // 
            // neededAmountColumn
            // 
            neededAmountColumn.DataPropertyName = "NeededAmount";
            neededAmountColumn.HeaderText = "Кол-во";
            neededAmountColumn.Name = "neededAmountColumn";
            neededAmountColumn.ReadOnly = true;
            // 
            // neededAmountBox
            // 
            neededAmountBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            neededAmountBox.Location = new Point(12, 97);
            neededAmountBox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            neededAmountBox.Name = "neededAmountBox";
            neededAmountBox.Size = new Size(332, 26);
            neededAmountBox.TabIndex = 15;
            // 
            // neededAmountLabel
            // 
            neededAmountLabel.AutoSize = true;
            neededAmountLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            neededAmountLabel.Location = new Point(12, 75);
            neededAmountLabel.Name = "neededAmountLabel";
            neededAmountLabel.Size = new Size(172, 19);
            neededAmountLabel.TabIndex = 14;
            neededAmountLabel.Text = "Требуемое количество:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            materialLabel.Location = new Point(12, 15);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(83, 19);
            materialLabel.TabIndex = 19;
            materialLabel.Text = "Операция:";
            // 
            // partLabel
            // 
            partLabel.AutoSize = true;
            partLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            partLabel.Location = new Point(12, 48);
            partLabel.Name = "partLabel";
            partLabel.Size = new Size(65, 19);
            partLabel.TabIndex = 20;
            partLabel.Text = "Деталь:";
            // 
            // materialBox
            // 
            materialBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            materialBox.Location = new Point(101, 12);
            materialBox.Name = "materialBox";
            materialBox.Size = new Size(243, 27);
            materialBox.TabIndex = 21;
            // 
            // partBox
            // 
            partBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            partBox.Location = new Point(83, 45);
            partBox.Name = "partBox";
            partBox.Size = new Size(261, 27);
            partBox.TabIndex = 22;
            // 
            // OperationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 415);
            Controls.Add(partBox);
            Controls.Add(materialBox);
            Controls.Add(partLabel);
            Controls.Add(materialLabel);
            Controls.Add(neededAmountBox);
            Controls.Add(neededAmountLabel);
            Controls.Add(dataGrid);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "OperationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Операции";
            Load += OnLoadAsync;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)neededAmountBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGrid;
        private Label neededAmountLabel;
        private NumericUpDown neededAmountBox;
        private Label materialLabel;
        private Label partLabel;
        private ComboBox materialBox;
        private ComboBox partBox;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn partIdColumn;
        private DataGridViewTextBoxColumn materialIdColumn;
        private DataGridViewTextBoxColumn neededAmountColumn;
    }
}
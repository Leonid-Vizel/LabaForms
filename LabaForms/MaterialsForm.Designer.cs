namespace LabaForms
{
    partial class MaterialsForm
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
            nameBox = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            dataGrid = new DataGridView();
            measurementLabel = new Label();
            measurementBox = new TextBox();
            priceBox = new NumericUpDown();
            priceLabel = new Label();
            idColumn = new DataGridViewTextBoxColumn();
            nameColumn = new DataGridViewTextBoxColumn();
            measurementColumn = new DataGridViewTextBoxColumn();
            planPriceColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceBox).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            nameLabel.Location = new Point(12, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 19);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Имя:";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(60, 15);
            nameBox.MaxLength = 1000;
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(284, 26);
            nameBox.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(12, 111);
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
            btnCancel.Location = new Point(252, 111);
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
            btnDelete.Location = new Point(129, 111);
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
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { idColumn, nameColumn, measurementColumn, planPriceColumn });
            dataGrid.Location = new Point(350, 15);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 24;
            dataGrid.Size = new Size(530, 377);
            dataGrid.TabIndex = 10;
            dataGrid.DoubleClick += OnGridDoubleClick;
            // 
            // measurementLabel
            // 
            measurementLabel.AutoSize = true;
            measurementLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            measurementLabel.Location = new Point(12, 50);
            measurementLabel.Name = "measurementLabel";
            measurementLabel.Size = new Size(78, 19);
            measurementLabel.TabIndex = 13;
            measurementLabel.Text = "Единицы:";
            // 
            // measurementBox
            // 
            measurementBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            measurementBox.Location = new Point(96, 47);
            measurementBox.MaxLength = 100;
            measurementBox.Name = "measurementBox";
            measurementBox.Size = new Size(248, 26);
            measurementBox.TabIndex = 12;
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            priceBox.Location = new Point(105, 79);
            priceBox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(239, 26);
            priceBox.TabIndex = 15;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            priceLabel.Location = new Point(12, 82);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(87, 19);
            priceLabel.TabIndex = 14;
            priceLabel.Text = "Стоимость:";
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
            // nameColumn
            // 
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Название";
            nameColumn.MinimumWidth = 6;
            nameColumn.Name = "nameColumn";
            nameColumn.ReadOnly = true;
            nameColumn.Width = 125;
            // 
            // measurementColumn
            // 
            measurementColumn.DataPropertyName = "Measurement";
            measurementColumn.HeaderText = "Единицы";
            measurementColumn.Name = "measurementColumn";
            measurementColumn.ReadOnly = true;
            // 
            // planPriceColumn
            // 
            planPriceColumn.DataPropertyName = "PlanPrice";
            planPriceColumn.HeaderText = "Стоимость";
            planPriceColumn.Name = "planPriceColumn";
            planPriceColumn.ReadOnly = true;
            // 
            // MaterialsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 415);
            Controls.Add(priceBox);
            Controls.Add(priceLabel);
            Controls.Add(measurementLabel);
            Controls.Add(measurementBox);
            Controls.Add(dataGrid);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(nameLabel);
            Controls.Add(nameBox);
            Name = "MaterialsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Материалы";
            Load += OnLoadAsync;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGrid;
        private Label measurementLabel;
        private TextBox measurementBox;
        private NumericUpDown priceBox;
        private Label priceLabel;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn measurementColumn;
        private DataGridViewTextBoxColumn planPriceColumn;
    }
}
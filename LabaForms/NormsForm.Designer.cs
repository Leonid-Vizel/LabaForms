namespace LabaForms
{
    partial class NormsForm
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
            operationIdColumn = new DataGridViewTextBoxColumn();
            partIdColumn = new DataGridViewTextBoxColumn();
            professionIdColumn = new DataGridViewTextBoxColumn();
            tarifIdColumn = new DataGridViewTextBoxColumn();
            qualificationColumn = new DataGridViewTextBoxColumn();
            pieceTimeColumn = new DataGridViewTextBoxColumn();
            finalTimeColumnColumn = new DataGridViewTextBoxColumn();
            qualificationLabel = new Label();
            qualificationBox = new TextBox();
            finalMinuteTimeBox = new NumericUpDown();
            finalMinuteTimeLabel = new Label();
            pieceMinuteTimeBox = new NumericUpDown();
            pieceMinuteTimeLabel = new Label();
            operationLabel = new Label();
            partLabel = new Label();
            operationBox = new ComboBox();
            partBox = new ComboBox();
            professionBox = new ComboBox();
            professionLabel = new Label();
            tarifBox = new ComboBox();
            tarifLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)finalMinuteTimeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pieceMinuteTimeBox).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(12, 278);
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
            btnCancel.Location = new Point(252, 278);
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
            btnDelete.Location = new Point(129, 278);
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
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { operationIdColumn, partIdColumn, professionIdColumn, tarifIdColumn, qualificationColumn, pieceTimeColumn, finalTimeColumnColumn });
            dataGrid.Location = new Point(350, 15);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 24;
            dataGrid.Size = new Size(755, 377);
            dataGrid.TabIndex = 10;
            dataGrid.DoubleClick += OnGridDoubleClick;
            // 
            // operationIdColumn
            // 
            operationIdColumn.DataPropertyName = "OperationId";
            operationIdColumn.HeaderText = "ИД операции";
            operationIdColumn.Name = "operationIdColumn";
            operationIdColumn.ReadOnly = true;
            // 
            // partIdColumn
            // 
            partIdColumn.DataPropertyName = "PartId";
            partIdColumn.HeaderText = "ИД детали";
            partIdColumn.Name = "partIdColumn";
            partIdColumn.ReadOnly = true;
            // 
            // professionIdColumn
            // 
            professionIdColumn.DataPropertyName = "ProfessionId";
            professionIdColumn.HeaderText = "ИД профессии";
            professionIdColumn.Name = "professionIdColumn";
            professionIdColumn.ReadOnly = true;
            // 
            // tarifIdColumn
            // 
            tarifIdColumn.DataPropertyName = "TarifId";
            tarifIdColumn.HeaderText = "ИД тарифа";
            tarifIdColumn.Name = "tarifIdColumn";
            tarifIdColumn.ReadOnly = true;
            // 
            // qualificationColumn
            // 
            qualificationColumn.DataPropertyName = "Qualification";
            qualificationColumn.HeaderText = "Квалификация";
            qualificationColumn.Name = "qualificationColumn";
            qualificationColumn.ReadOnly = true;
            // 
            // pieceTimeColumn
            // 
            pieceTimeColumn.DataPropertyName = "PieceMinuteTime";
            pieceTimeColumn.HeaderText = "Время за единицу";
            pieceTimeColumn.Name = "pieceTimeColumn";
            pieceTimeColumn.ReadOnly = true;
            // 
            // finalTimeColumnColumn
            // 
            finalTimeColumnColumn.DataPropertyName = "FinalMinuteTime";
            finalTimeColumnColumn.HeaderText = "Финальное время";
            finalTimeColumnColumn.Name = "finalTimeColumnColumn";
            finalTimeColumnColumn.ReadOnly = true;
            // 
            // qualificationLabel
            // 
            qualificationLabel.AutoSize = true;
            qualificationLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            qualificationLabel.Location = new Point(12, 147);
            qualificationLabel.Name = "qualificationLabel";
            qualificationLabel.Size = new Size(117, 19);
            qualificationLabel.TabIndex = 13;
            qualificationLabel.Text = "Квалификация:";
            // 
            // qualificationBox
            // 
            qualificationBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qualificationBox.Location = new Point(135, 144);
            qualificationBox.MaxLength = 2000;
            qualificationBox.Name = "qualificationBox";
            qualificationBox.Size = new Size(209, 26);
            qualificationBox.TabIndex = 12;
            // 
            // finalMinuteTimeBox
            // 
            finalMinuteTimeBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            finalMinuteTimeBox.Location = new Point(12, 246);
            finalMinuteTimeBox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            finalMinuteTimeBox.Name = "finalMinuteTimeBox";
            finalMinuteTimeBox.Size = new Size(332, 26);
            finalMinuteTimeBox.TabIndex = 15;
            // 
            // finalMinuteTimeLabel
            // 
            finalMinuteTimeLabel.AutoSize = true;
            finalMinuteTimeLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            finalMinuteTimeLabel.Location = new Point(12, 224);
            finalMinuteTimeLabel.Name = "finalMinuteTimeLabel";
            finalMinuteTimeLabel.Size = new Size(191, 19);
            finalMinuteTimeLabel.TabIndex = 14;
            finalMinuteTimeLabel.Text = "Финальные времязатраты:";
            // 
            // pieceMinuteTimeBox
            // 
            pieceMinuteTimeBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            pieceMinuteTimeBox.Location = new Point(12, 195);
            pieceMinuteTimeBox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            pieceMinuteTimeBox.Name = "pieceMinuteTimeBox";
            pieceMinuteTimeBox.Size = new Size(332, 26);
            pieceMinuteTimeBox.TabIndex = 18;
            // 
            // pieceMinuteTimeLabel
            // 
            pieceMinuteTimeLabel.AutoSize = true;
            pieceMinuteTimeLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            pieceMinuteTimeLabel.Location = new Point(12, 173);
            pieceMinuteTimeLabel.Name = "pieceMinuteTimeLabel";
            pieceMinuteTimeLabel.Size = new Size(195, 19);
            pieceMinuteTimeLabel.TabIndex = 17;
            pieceMinuteTimeLabel.Text = "Времязатраты за единицу:";
            // 
            // operationLabel
            // 
            operationLabel.AutoSize = true;
            operationLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            operationLabel.Location = new Point(12, 15);
            operationLabel.Name = "operationLabel";
            operationLabel.Size = new Size(83, 19);
            operationLabel.TabIndex = 19;
            operationLabel.Text = "Операция:";
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
            // operationBox
            // 
            operationBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            operationBox.Location = new Point(101, 12);
            operationBox.Name = "operationBox";
            operationBox.Size = new Size(243, 27);
            operationBox.TabIndex = 21;
            // 
            // partBox
            // 
            partBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            partBox.Location = new Point(83, 45);
            partBox.Name = "partBox";
            partBox.Size = new Size(261, 27);
            partBox.TabIndex = 22;
            // 
            // professionBox
            // 
            professionBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            professionBox.Location = new Point(110, 78);
            professionBox.Name = "professionBox";
            professionBox.Size = new Size(234, 27);
            professionBox.TabIndex = 24;
            // 
            // professionLabel
            // 
            professionLabel.AutoSize = true;
            professionLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            professionLabel.Location = new Point(12, 81);
            professionLabel.Name = "professionLabel";
            professionLabel.Size = new Size(92, 19);
            professionLabel.TabIndex = 23;
            professionLabel.Text = "Профессия:";
            // 
            // tarifBox
            // 
            tarifBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            tarifBox.Location = new Point(83, 111);
            tarifBox.Name = "tarifBox";
            tarifBox.Size = new Size(261, 27);
            tarifBox.TabIndex = 26;
            // 
            // tarifLabel
            // 
            tarifLabel.AutoSize = true;
            tarifLabel.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            tarifLabel.Location = new Point(12, 114);
            tarifLabel.Name = "tarifLabel";
            tarifLabel.Size = new Size(60, 19);
            tarifLabel.TabIndex = 25;
            tarifLabel.Text = "Тариф:";
            // 
            // NormsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 415);
            Controls.Add(tarifBox);
            Controls.Add(tarifLabel);
            Controls.Add(professionBox);
            Controls.Add(professionLabel);
            Controls.Add(partBox);
            Controls.Add(operationBox);
            Controls.Add(partLabel);
            Controls.Add(operationLabel);
            Controls.Add(pieceMinuteTimeBox);
            Controls.Add(pieceMinuteTimeLabel);
            Controls.Add(finalMinuteTimeBox);
            Controls.Add(finalMinuteTimeLabel);
            Controls.Add(qualificationLabel);
            Controls.Add(qualificationBox);
            Controls.Add(dataGrid);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "NormsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пооперационные нормы";
            Load += OnLoadAsync;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)finalMinuteTimeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pieceMinuteTimeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGrid;
        private Label qualificationLabel;
        private TextBox qualificationBox;
        private NumericUpDown finalMinuteTimeBox;
        private Label finalMinuteTimeLabel;
        private NumericUpDown pieceMinuteTimeBox;
        private Label pieceMinuteTimeLabel;
        private Label operationLabel;
        private Label partLabel;
        private ComboBox operationBox;
        private ComboBox partBox;
        private ComboBox professionBox;
        private Label professionLabel;
        private ComboBox tarifBox;
        private Label tarifLabel;
        private DataGridViewTextBoxColumn operationIdColumn;
        private DataGridViewTextBoxColumn partIdColumn;
        private DataGridViewTextBoxColumn professionIdColumn;
        private DataGridViewTextBoxColumn tarifIdColumn;
        private DataGridViewTextBoxColumn qualificationColumn;
        private DataGridViewTextBoxColumn pieceTimeColumn;
        private DataGridViewTextBoxColumn finalTimeColumnColumn;
    }
}
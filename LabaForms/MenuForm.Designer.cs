namespace LabaForms
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            materialsButton = new Button();
            partsButton = new Button();
            professionsButton = new Button();
            tarifsButton = new Button();
            operationsButton = new Button();
            normsButton = new Button();
            queriesButton = new Button();
            SuspendLayout();
            // 
            // materialsButton
            // 
            materialsButton.Location = new Point(14, 14);
            materialsButton.Margin = new Padding(4, 3, 4, 3);
            materialsButton.Name = "materialsButton";
            materialsButton.Size = new Size(231, 39);
            materialsButton.TabIndex = 0;
            materialsButton.Text = "Материалы";
            materialsButton.UseVisualStyleBackColor = true;
            materialsButton.Click += OnMaterialButtonClick;
            // 
            // partsButton
            // 
            partsButton.Location = new Point(14, 60);
            partsButton.Margin = new Padding(4, 3, 4, 3);
            partsButton.Name = "partsButton";
            partsButton.Size = new Size(231, 39);
            partsButton.TabIndex = 1;
            partsButton.Text = "Детали";
            partsButton.UseVisualStyleBackColor = true;
            partsButton.Click += OnPartsButtonClick;
            // 
            // professionsButton
            // 
            professionsButton.Location = new Point(14, 106);
            professionsButton.Margin = new Padding(4, 3, 4, 3);
            professionsButton.Name = "professionsButton";
            professionsButton.Size = new Size(231, 39);
            professionsButton.TabIndex = 2;
            professionsButton.Text = "Профессии";
            professionsButton.UseVisualStyleBackColor = true;
            professionsButton.Click += OnProfessionsButtonClick;
            // 
            // tarifsButton
            // 
            tarifsButton.Location = new Point(14, 152);
            tarifsButton.Margin = new Padding(4, 3, 4, 3);
            tarifsButton.Name = "tarifsButton";
            tarifsButton.Size = new Size(231, 39);
            tarifsButton.TabIndex = 3;
            tarifsButton.Text = "Тарифы";
            tarifsButton.UseVisualStyleBackColor = true;
            tarifsButton.Click += OnTarifsButtonClick;
            // 
            // operationsButton
            // 
            operationsButton.Location = new Point(14, 198);
            operationsButton.Margin = new Padding(4, 3, 4, 3);
            operationsButton.Name = "operationsButton";
            operationsButton.Size = new Size(231, 39);
            operationsButton.TabIndex = 4;
            operationsButton.Text = "Операции";
            operationsButton.UseVisualStyleBackColor = true;
            operationsButton.Click += OnOperationsButtonClick;
            // 
            // normsButton
            // 
            normsButton.Location = new Point(14, 245);
            normsButton.Margin = new Padding(4, 3, 4, 3);
            normsButton.Name = "normsButton";
            normsButton.Size = new Size(231, 39);
            normsButton.TabIndex = 5;
            normsButton.Text = "Нормы";
            normsButton.UseVisualStyleBackColor = true;
            normsButton.Click += OnNormsButtonClick;
            // 
            // queriesButton
            // 
            queriesButton.Location = new Point(15, 291);
            queriesButton.Margin = new Padding(4, 3, 4, 3);
            queriesButton.Name = "queriesButton";
            queriesButton.Size = new Size(231, 39);
            queriesButton.TabIndex = 6;
            queriesButton.Text = "Доп. запросы";
            queriesButton.UseVisualStyleBackColor = true;
            queriesButton.Click += OnQueriesButtonClick;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 345);
            Controls.Add(queriesButton);
            Controls.Add(normsButton);
            Controls.Add(operationsButton);
            Controls.Add(tarifsButton);
            Controls.Add(professionsButton);
            Controls.Add(partsButton);
            Controls.Add(materialsButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню";
            Load += OnLoad;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button materialsButton;
        private System.Windows.Forms.Button partsButton;
        private System.Windows.Forms.Button professionsButton;
        private System.Windows.Forms.Button tarifsButton;
        private System.Windows.Forms.Button operationsButton;
        private System.Windows.Forms.Button normsButton;
        private System.Windows.Forms.Button queriesButton;
    }
}


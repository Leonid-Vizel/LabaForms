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
            query1Button = new Button();
            query2Button = new Button();
            query3Button = new Button();
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
            // query1Button
            // 
            query1Button.Location = new Point(14, 291);
            query1Button.Margin = new Padding(4, 3, 4, 3);
            query1Button.Name = "query1Button";
            query1Button.Size = new Size(231, 39);
            query1Button.TabIndex = 6;
            query1Button.Text = "Доп. запрос 1";
            query1Button.UseVisualStyleBackColor = true;
            query1Button.Click += OnQuery1ButtonClick;
            // 
            // query2Button
            // 
            query2Button.Location = new Point(14, 336);
            query2Button.Margin = new Padding(4, 3, 4, 3);
            query2Button.Name = "query2Button";
            query2Button.Size = new Size(231, 39);
            query2Button.TabIndex = 7;
            query2Button.Text = "Доп. запрос 2";
            query2Button.UseVisualStyleBackColor = true;
            query2Button.Click += OnQuery2ButtonClick;
            // 
            // query3Button
            // 
            query3Button.Location = new Point(13, 381);
            query3Button.Margin = new Padding(4, 3, 4, 3);
            query3Button.Name = "query3Button";
            query3Button.Size = new Size(231, 39);
            query3Button.TabIndex = 8;
            query3Button.Text = "Доп. запрос 3";
            query3Button.UseVisualStyleBackColor = true;
            query3Button.Click += OnQuery3ButtonClick;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 434);
            Controls.Add(query3Button);
            Controls.Add(query2Button);
            Controls.Add(query1Button);
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
        private System.Windows.Forms.Button query1Button;
        private Button query2Button;
        private Button query3Button;
    }
}


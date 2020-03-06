namespace PPR_lab1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Start = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.F1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.NumericUpDown();
            this.RowValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.e1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonHL = new System.Windows.Forms.RadioButton();
            this.radioButtonGy = new System.Windows.Forms.RadioButton();
            this.radioButtonBL = new System.Windows.Forms.RadioButton();
            this.radioButtonMM = new System.Windows.Forms.RadioButton();
            this.numС = new System.Windows.Forms.NumericUpDown();
            this.label_Gy = new System.Windows.Forms.Label();
            this.labelHL = new System.Windows.Forms.Label();
            this.numHL = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButtonSe = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numС)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHL)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(785, 498);
            this.Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(120, 32);
            this.Start.TabIndex = 1;
            this.Start.Text = "Расчитать";
            this.Start.UseMnemonic = false;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(16, 575);
            this.Answer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(255, 22);
            this.Answer.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F1,
            this.F2,
            this.F3});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(692, 230);
            this.dataGridView.TabIndex = 1;
            // 
            // F1
            // 
            this.F1.HeaderText = "F1";
            this.F1.Name = "F1";
            // 
            // F2
            // 
            this.F2.Name = "F2";
            // 
            // F3
            // 
            this.F3.Name = "F3";
            // 
            // ColumnValue
            // 
            this.ColumnValue.Location = new System.Drawing.Point(151, 257);
            this.ColumnValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.Size = new System.Drawing.Size(120, 22);
            this.ColumnValue.TabIndex = 4;
            this.ColumnValue.ValueChanged += new System.EventHandler(this.ColumnValue_ValueChanged);
            // 
            // RowValue
            // 
            this.RowValue.Location = new System.Drawing.Point(416, 257);
            this.RowValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RowValue.Name = "RowValue";
            this.RowValue.Size = new System.Drawing.Size(120, 22);
            this.RowValue.TabIndex = 5;
            this.RowValue.ValueChanged += new System.EventHandler(this.RowValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кол-во столбцов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(281, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во строк";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(785, 247);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "ЗАДАЧА 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 545);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "ОТВЕТ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.e1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(711, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(193, 229);
            this.dataGridView1.TabIndex = 10;
            // 
            // e1
            // 
            this.e1.HeaderText = "e1";
            this.e1.Name = "e1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSe);
            this.groupBox1.Controls.Add(this.radioButtonHL);
            this.groupBox1.Controls.Add(this.radioButtonGy);
            this.groupBox1.Controls.Add(this.radioButtonBL);
            this.groupBox1.Controls.Add(this.radioButtonMM);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(259, 173);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод решения";
            // 
            // radioButtonHL
            // 
            this.radioButtonHL.AutoSize = true;
            this.radioButtonHL.Location = new System.Drawing.Point(9, 113);
            this.radioButtonHL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonHL.Name = "radioButtonHL";
            this.radioButtonHL.Size = new System.Drawing.Size(195, 21);
            this.radioButtonHL.TabIndex = 3;
            this.radioButtonHL.Text = "Критерия Ходжа-Лемана";
            this.radioButtonHL.UseVisualStyleBackColor = true;
            this.radioButtonHL.CheckedChanged += new System.EventHandler(this.radioButtonHL_CheckedChanged);
            // 
            // radioButtonGy
            // 
            this.radioButtonGy.AutoSize = true;
            this.radioButtonGy.Location = new System.Drawing.Point(9, 84);
            this.radioButtonGy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonGy.Name = "radioButtonGy";
            this.radioButtonGy.Size = new System.Drawing.Size(151, 21);
            this.radioButtonGy.TabIndex = 2;
            this.radioButtonGy.Text = "Критерий Гурвица";
            this.radioButtonGy.UseVisualStyleBackColor = true;
            this.radioButtonGy.CheckedChanged += new System.EventHandler(this.radioButtonGy_CheckedChanged);
            // 
            // radioButtonBL
            // 
            this.radioButtonBL.AutoSize = true;
            this.radioButtonBL.Location = new System.Drawing.Point(9, 54);
            this.radioButtonBL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonBL.Name = "radioButtonBL";
            this.radioButtonBL.Size = new System.Drawing.Size(207, 21);
            this.radioButtonBL.TabIndex = 1;
            this.radioButtonBL.Text = "Критерий Байеса-Лапласа";
            this.radioButtonBL.UseVisualStyleBackColor = true;
            this.radioButtonBL.CheckedChanged += new System.EventHandler(this.radioButtonBL_CheckedChanged);
            // 
            // radioButtonMM
            // 
            this.radioButtonMM.AutoSize = true;
            this.radioButtonMM.Checked = true;
            this.radioButtonMM.Location = new System.Drawing.Point(9, 25);
            this.radioButtonMM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMM.Name = "radioButtonMM";
            this.radioButtonMM.Size = new System.Drawing.Size(187, 21);
            this.radioButtonMM.TabIndex = 0;
            this.radioButtonMM.TabStop = true;
            this.radioButtonMM.Text = "Минимаксный критерий";
            this.radioButtonMM.UseVisualStyleBackColor = true;
            this.radioButtonMM.CheckedChanged += new System.EventHandler(this.radioButtonMM_CheckedChanged);
            // 
            // numС
            // 
            this.numС.DecimalPlaces = 2;
            this.numС.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numС.Location = new System.Drawing.Point(333, 399);
            this.numС.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numС.Name = "numС";
            this.numС.Size = new System.Drawing.Size(64, 22);
            this.numС.TabIndex = 12;
            // 
            // label_Gy
            // 
            this.label_Gy.AutoSize = true;
            this.label_Gy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Gy.Location = new System.Drawing.Point(281, 404);
            this.label_Gy.Name = "label_Gy";
            this.label_Gy.Size = new System.Drawing.Size(29, 17);
            this.label_Gy.TabIndex = 13;
            this.label_Gy.Text = "С =";
            // 
            // labelHL
            // 
            this.labelHL.AutoSize = true;
            this.labelHL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHL.Location = new System.Drawing.Point(281, 433);
            this.labelHL.Name = "labelHL";
            this.labelHL.Size = new System.Drawing.Size(50, 17);
            this.labelHL.TabIndex = 15;
            this.labelHL.Text = "(1-v) =";
            // 
            // numHL
            // 
            this.numHL.DecimalPlaces = 2;
            this.numHL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numHL.Location = new System.Drawing.Point(333, 428);
            this.numHL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHL.Name = "numHL";
            this.numHL.Size = new System.Drawing.Size(64, 22);
            this.numHL.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(785, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "ЗАДАЧА 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(785, 326);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 34);
            this.button3.TabIndex = 17;
            this.button3.Text = "ЗАДАЧА 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(785, 366);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 34);
            this.button4.TabIndex = 18;
            this.button4.Text = "ЗАДАЧА 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButtonSe
            // 
            this.radioButtonSe.AutoSize = true;
            this.radioButtonSe.Location = new System.Drawing.Point(9, 142);
            this.radioButtonSe.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSe.Name = "radioButtonSe";
            this.radioButtonSe.Size = new System.Drawing.Size(153, 21);
            this.radioButtonSe.TabIndex = 4;
            this.radioButtonSe.Text = "Критерия Сэвиджа";
            this.radioButtonSe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(920, 620);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelHL);
            this.Controls.Add(this.numHL);
            this.Controls.Add(this.label_Gy);
            this.Controls.Add(this.numС);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RowValue);
            this.Controls.Add(this.ColumnValue);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Start);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "PPR_lab1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numС)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn F1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F2;
        private System.Windows.Forms.DataGridViewTextBoxColumn F3;
        private System.Windows.Forms.NumericUpDown ColumnValue;
        private System.Windows.Forms.NumericUpDown RowValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn e1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonHL;
        private System.Windows.Forms.RadioButton radioButtonGy;
        private System.Windows.Forms.RadioButton radioButtonBL;
        private System.Windows.Forms.RadioButton radioButtonMM;
        private System.Windows.Forms.NumericUpDown numС;
        private System.Windows.Forms.Label label_Gy;
        private System.Windows.Forms.Label labelHL;
        private System.Windows.Forms.NumericUpDown numHL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioButtonSe;
    }
}


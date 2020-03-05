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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Start.Location = new System.Drawing.Point(589, 405);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(90, 26);
            this.Start.TabIndex = 1;
            this.Start.Text = "Расчитать";
            this.Start.UseMnemonic = false;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(11, 411);
            this.Answer.Margin = new System.Windows.Forms.Padding(2);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(192, 20);
            this.Answer.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F1,
            this.F2,
            this.F3});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView.Location = new System.Drawing.Point(9, 10);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(519, 187);
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
            this.ColumnValue.Location = new System.Drawing.Point(113, 209);
            this.ColumnValue.Margin = new System.Windows.Forms.Padding(2);
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.Size = new System.Drawing.Size(90, 20);
            this.ColumnValue.TabIndex = 4;
            this.ColumnValue.ValueChanged += new System.EventHandler(this.ColumnValue_ValueChanged);
            // 
            // RowValue
            // 
            this.RowValue.Location = new System.Drawing.Point(312, 209);
            this.RowValue.Margin = new System.Windows.Forms.Padding(2);
            this.RowValue.Name = "RowValue";
            this.RowValue.Size = new System.Drawing.Size(90, 20);
            this.RowValue.TabIndex = 5;
            this.RowValue.ValueChanged += new System.EventHandler(this.RowValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кол-во столбцов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(211, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во строк";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "ЗАДАЧА 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(8, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ОТВЕТ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.e1});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Location = new System.Drawing.Point(533, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(145, 186);
            this.dataGridView1.TabIndex = 10;
            // 
            // e1
            // 
            this.e1.HeaderText = "e1";
            this.e1.Name = "e1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonHL);
            this.groupBox1.Controls.Add(this.radioButtonGy);
            this.groupBox1.Controls.Add(this.radioButtonBL);
            this.groupBox1.Controls.Add(this.radioButtonMM);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(9, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 117);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод решения";
            // 
            // radioButtonHL
            // 
            this.radioButtonHL.AutoSize = true;
            this.radioButtonHL.Location = new System.Drawing.Point(7, 92);
            this.radioButtonHL.Name = "radioButtonHL";
            this.radioButtonHL.Size = new System.Drawing.Size(152, 17);
            this.radioButtonHL.TabIndex = 3;
            this.radioButtonHL.Text = "Критерия Ходжа-Лемана";
            this.radioButtonHL.UseVisualStyleBackColor = true;
            this.radioButtonHL.CheckedChanged += new System.EventHandler(this.radioButtonHL_CheckedChanged);
            // 
            // radioButtonGy
            // 
            this.radioButtonGy.AutoSize = true;
            this.radioButtonGy.Location = new System.Drawing.Point(7, 68);
            this.radioButtonGy.Name = "radioButtonGy";
            this.radioButtonGy.Size = new System.Drawing.Size(117, 17);
            this.radioButtonGy.TabIndex = 2;
            this.radioButtonGy.Text = "Критерий Гурвица";
            this.radioButtonGy.UseVisualStyleBackColor = true;
            this.radioButtonGy.CheckedChanged += new System.EventHandler(this.radioButtonGy_CheckedChanged);
            // 
            // radioButtonBL
            // 
            this.radioButtonBL.AutoSize = true;
            this.radioButtonBL.Location = new System.Drawing.Point(7, 44);
            this.radioButtonBL.Name = "radioButtonBL";
            this.radioButtonBL.Size = new System.Drawing.Size(160, 17);
            this.radioButtonBL.TabIndex = 1;
            this.radioButtonBL.Text = "Критерий Байеса-Лапласа";
            this.radioButtonBL.UseVisualStyleBackColor = true;
            this.radioButtonBL.CheckedChanged += new System.EventHandler(this.radioButtonBL_CheckedChanged);
            // 
            // radioButtonMM
            // 
            this.radioButtonMM.AutoSize = true;
            this.radioButtonMM.Checked = true;
            this.radioButtonMM.Location = new System.Drawing.Point(7, 20);
            this.radioButtonMM.Name = "radioButtonMM";
            this.radioButtonMM.Size = new System.Drawing.Size(148, 17);
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
            this.numС.Location = new System.Drawing.Point(250, 324);
            this.numС.Margin = new System.Windows.Forms.Padding(2);
            this.numС.Name = "numС";
            this.numС.Size = new System.Drawing.Size(48, 20);
            this.numС.TabIndex = 12;
            // 
            // label_Gy
            // 
            this.label_Gy.AutoSize = true;
            this.label_Gy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Gy.Location = new System.Drawing.Point(211, 328);
            this.label_Gy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Gy.Name = "label_Gy";
            this.label_Gy.Size = new System.Drawing.Size(23, 13);
            this.label_Gy.TabIndex = 13;
            this.label_Gy.Text = "С =";
            // 
            // labelHL
            // 
            this.labelHL.AutoSize = true;
            this.labelHL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHL.Location = new System.Drawing.Point(211, 352);
            this.labelHL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHL.Name = "labelHL";
            this.labelHL.Size = new System.Drawing.Size(37, 13);
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
            this.numHL.Location = new System.Drawing.Point(250, 348);
            this.numHL.Margin = new System.Windows.Forms.Padding(2);
            this.numHL.Name = "numHL";
            this.numHL.Size = new System.Drawing.Size(48, 20);
            this.numHL.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 233);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "ЗАДАЧА 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(589, 265);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "ЗАДАЧА 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(589, 297);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 28);
            this.button4.TabIndex = 18;
            this.button4.Text = "ЗАДАЧА 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(690, 442);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}


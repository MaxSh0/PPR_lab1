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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowValue)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(668, 406);
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
            this.Answer.Location = new System.Drawing.Point(53, 406);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(255, 22);
            this.Answer.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F1,
            this.F2,
            this.F3});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(776, 150);
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
            this.ColumnValue.Location = new System.Drawing.Point(147, 185);
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.Size = new System.Drawing.Size(120, 22);
            this.ColumnValue.TabIndex = 4;
            this.ColumnValue.ValueChanged += new System.EventHandler(this.ColumnValue_ValueChanged);
            // 
            // RowValue
            // 
            this.RowValue.Location = new System.Drawing.Point(147, 232);
            this.RowValue.Name = "RowValue";
            this.RowValue.Size = new System.Drawing.Size(120, 22);
            this.RowValue.TabIndex = 5;
            this.RowValue.ValueChanged += new System.EventHandler(this.RowValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кол-во столбцов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во строк";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "ЗАДАЧА 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RowValue);
            this.Controls.Add(this.ColumnValue);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowValue)).EndInit();
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
    }
}


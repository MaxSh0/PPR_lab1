using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPR_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            dataGridView.Width = 670;
            ColumnValue.Value = 1;
            RowValue.Value = 1;
        }

        //Кнопка решить
        private void button1_Click(object sender, EventArgs e)
        {
            double[,] matrix = new double [Convert.ToInt32(RowValue.Value),Convert.ToInt32(ColumnValue.Value)];
            if (!error())
            {
                Table_in_matrix(matrix);
                if (radioButtonMM.Checked)
                {
                    Answer.Text = MM(matrix);
                }
                else if (radioButtonBL.Checked)
                {
                    Answer.Text = BL(matrix);
                }
            }
        }

        //Метод выбора с использованием Минимаксного критерия
        string MM(double[,] matrix)
        {
            double[] arr_max;
            arr_max = min(matrix);

            return max(arr_max).ToString();
        }

        //возвращает массив наименьших элементов в строках 2D массива
        double[] min(double[,] matrix)
        {
            double[] arr_min = new double[matrix.GetLength(0)];
            for (int n = 0; n < Convert.ToInt32(RowValue.Value); n++)
            {
                arr_min[n] = matrix[n, 0];
            }
            double cur_val;
            for (int i = 0; i < Convert.ToInt32(RowValue.Value); i++)
            {
                for (int j = 0; j < Convert.ToInt32(ColumnValue.Value); j++)
                {
                    cur_val = matrix[i, j];
                    if (cur_val < arr_min[i])
                    {
                        arr_min[i] = cur_val;
                    }
                }
            }
            return arr_min;
        }


        // критерий Байерса-Лапласа
        string BL(double[,] matrix)
        {
            double[] arr_additionally = new double[Convert.ToInt32(RowValue.Value)];
            matrix = Table_in_matrix(matrix);
            double calculated_column_value = 0;
            for (int i = 0; i < RowValue.Value; i++)
            {
                for (int j = 0; j < ColumnValue.Value; j++)
                {
                    calculated_column_value += matrix[i, j] * Convert.ToDouble(dataGridView1[0, j].Value); 
                }
                arr_additionally[i] = calculated_column_value;
                calculated_column_value = 0;
            }
            return max(arr_additionally).ToString();
        }


        // преобразует таблицу в 2D массив
        double[,] Table_in_matrix(double[,] matrix)
        {
            for (int i = 0; i < Convert.ToInt32(RowValue.Value); i++)
            {
                for (int j = 0; j < Convert.ToInt32(ColumnValue.Value); j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridView[j, i].Value);
                }
            }
            return matrix;
        }

        // возвращает максимальное значение в одномерном массиве
        double max(double[] arr)
        {
            double cur_val;
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                cur_val = arr[i];
                if (max < cur_val)
                {
                    max = cur_val;
                }
            }
            return max;
        }

        //Изменение кол-ва столбцов в таблице
        private void ColumnValue_ValueChanged(object sender, EventArgs e)
        {
            dataGridView.ColumnCount = Convert.ToInt32(ColumnValue.Value);
            dataGridView.Columns[Convert.ToInt32(ColumnValue.Value) - 1].HeaderText = "F" + ColumnValue.Value.ToString();
            dataGridView1.RowCount = Convert.ToInt32(ColumnValue.Value);
            dataGridView1.Rows[Convert.ToInt32(ColumnValue.Value) - 1].HeaderCell.Value = "e" + ColumnValue.Value.ToString();
        }

        //Изменение кол-ва строк в таблице
        private void RowValue_ValueChanged(object sender, EventArgs e)
        {   
            dataGridView.RowCount = Convert.ToInt32(RowValue.Value);
            dataGridView.Rows[Convert.ToInt32(RowValue.Value) - 1].HeaderCell.Value = "E" + RowValue.Value.ToString();
        }

        //кнопка ЗАДАЧА 1
        private void button1_Click_1(object sender, EventArgs e)
        {
            ColumnValue.Value = 1;
            RowValue.Value = 1;
            ColumnValue.Value = 2;
            RowValue.Value = 2;
            ColumnValue.Value = 3;
            RowValue.Value = 3;

            dataGridView[0, 0].Value = 10;
            dataGridView[1, 0].Value = -2;
            dataGridView[2, 0].Value = 8;
            dataGridView[0, 1].Value = -3;
            dataGridView[1, 1].Value = 5.2;
            dataGridView[2, 1].Value = 6;
            dataGridView[0, 2].Value = 7.5;
            dataGridView[1, 2].Value = 9;
            dataGridView[2, 2].Value = -1;

            dataGridView1[0, 0].Value = 0.5;
            dataGridView1[0, 1].Value = 0.3;
            dataGridView1[0, 2].Value = 0.2;

        }

        //Видимости при режиме MM
        private void radioButtonMM_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMM.Checked)
            {
                dataGridView1.Visible = false;
                dataGridView.Width = 670;
            }
        }

        //Видимости при режиме BL
        private void radioButtonBL_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBL.Checked)
            {
                dataGridView1.Visible = true;
                dataGridView.Width = 519;
            }
        }

        //Проверка на ошибки
        bool error()
        {
            double summBL = 0;
            for (int i = 0; i < Convert.ToInt32(ColumnValue.Value); i++)
            {
                summBL += Convert.ToDouble(dataGridView1[0, i].Value);
            }
            if (Math.Round(summBL,3) != 1)
            {
                MessageBox.Show("При использоании Критерия Байеса-Лапласа сумма вероятностей должна быть равна 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}

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
            numС.Visible = false;
            label_Gy.Visible = false;
            numHL.Visible = false;
            labelHL.Visible = false;
            dataGridView.Width = 670;
            ColumnValue.Value = 1;
            RowValue.Value = 1;
           
        }
        bool decided = false;
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
                else if (radioButtonGy.Checked)
                {
                    Answer.Text = Gy(matrix);
                }
                else if (radioButtonHL.Checked)
                {
                    Answer.Text = HL(matrix);
                }
                else if (radioButtonSe.Checked)
                {
                    Answer.Text = Se(matrix);
                }
                decided = true;
            }
        }

        //Метод выбора с использованием Минимаксного критерия
        string MM(double[,] matrix)
        {
            double[] arr_max;
            arr_max = min_2D(matrix);
            AdditionalCollumn(arr_max);

            return max_1D(arr_max).ToString();
        }

        //Критерий Байерса-Лапласа
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
            AdditionalCollumn(arr_additionally);
            return max_1D(arr_additionally).ToString();
        }

        //Критерий Гурвица
        string Gy(double[,] matrix)
        {
            matrix = Table_in_matrix(matrix);
            double[] arr_result = new double[matrix.GetLength(0)]; ;
            double[] arr_min = min_2D(matrix);
            double[] arr_max = max_2D(matrix);
            for (int i = 0; i < RowValue.Value; i++)
            {
                arr_result[i] = arr_min[i] * Convert.ToDouble(numС.Value) + arr_max[i] * (1 - Convert.ToDouble(numС.Value));
            }
            AdditionalCollumn(arr_result);
            return max_1D(arr_result).ToString();
        }

        //Критерий Ходжа-Лемана
        string HL(double[,] matrix)
        {
            matrix = Table_in_matrix(matrix);
            double[] arr_result = new double[matrix.GetLength(0)];
            double[] arr_min = min_2D(matrix);
            double valueInRow = 0;
            double q = 1/Convert.ToDouble(RowValue.Value);
            Math.Round(q, 3);
            for (int i = 0; i < RowValue.Value; i++)
            {
                for (int j = 0; j < ColumnValue.Value; j++)
                {
                    valueInRow += matrix[i, j] * q;
                }
                arr_result[i] = arr_min[i] * Convert.ToDouble(numHL.Value) + (valueInRow*(1-Convert.ToDouble(numHL.Value)));
                valueInRow = 0;
            }
            AdditionalCollumn(arr_result);
            return max_1D(arr_result).ToString();
        }

        string Se(double[,] matrix)
        {
            matrix = Table_in_matrix(matrix);
            double[] arr_max_row = maxInRow_2D(matrix);
            for (int i = 0; i < ColumnValue.Value; i++)
            {
                for (int j = 0; j < RowValue.Value; j++)
                {
                    matrix[j, i] = arr_max_row[i] - matrix[j, i];
                }
            }
            double[] arr_max = max_2D(matrix);
            AdditionalCollumn(arr_max);
            return min_1D(arr_max).ToString();
        }

        //возвращает массив наибольших элементов в столбцах 2D массива построчно
        double[] maxInRow_2D(double[,] matrix)
        {
            double[] arr_max = new double[matrix.GetLength(0)];
            double cur_val;
            for (int i = 0; i < Convert.ToInt32(ColumnValue.Value); i++)
            {
                for (int j = 0; j < Convert.ToInt32(RowValue.Value); j++)
                {
                    cur_val = matrix[j, i];
                    if (cur_val > arr_max[i])
                    {
                        arr_max[i] = cur_val;
                    }
                }
            }
            return arr_max;
        }

        //возвращает массив наименьших элементов в строках 2D массива построчно
        double[] min_2D(double[,] matrix)
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

        //возвращает массив наибольших элементов в строках 2D массива построчно
        double[] max_2D(double[,] matrix)
        {
            double[] arr_max = new double[matrix.GetLength(0)];
            for (int n = 0; n < Convert.ToInt32(RowValue.Value); n++)
            {
                arr_max[n] = matrix[n, 0];
            }
            double cur_val;
            for (int i = 0; i < Convert.ToInt32(RowValue.Value); i++)
            {
                for (int j = 0; j < Convert.ToInt32(ColumnValue.Value); j++)
                {
                    cur_val = matrix[i, j];
                    if (cur_val > arr_max[i])
                    {
                        arr_max[i] = cur_val;
                    }
                }
            }
            return arr_max;
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
        double max_1D(double[] arr)
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

        // возвращает минимальное значение в одномерном массиве
        double min_1D(double[] arr)
        {
            double cur_val;
            double min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                cur_val = arr[i];
                if (min > cur_val)
                {
                    min = cur_val;
                }
            }
            return min;
        }

        //Изменение кол-ва столбцов в таблице
        private void ColumnValue_ValueChanged(object sender, EventArgs e)
        {
            decided = false;
            dataGridView.ColumnCount = Convert.ToInt32(ColumnValue.Value);
            dataGridView.Columns[Convert.ToInt32(ColumnValue.Value) - 1].HeaderText = "F" + ColumnValue.Value.ToString();
            dataGridView1.RowCount = Convert.ToInt32(ColumnValue.Value);
            dataGridView1.Rows[Convert.ToInt32(ColumnValue.Value) - 1].HeaderCell.Value = "e" + ColumnValue.Value.ToString();
        }

        //Добавить столбец с доп значениями
        void AdditionalCollumn(double[] arr)
        {
            if (!decided)
            {
                dataGridView.ColumnCount += 1;
                dataGridView.Columns[Convert.ToInt32(ColumnValue.Value)].HeaderText = "Доп столбец";
                for (int i = 0; i < RowValue.Value; i++)
                {
                    dataGridView[Convert.ToInt32(ColumnValue.Value),i].Value = arr[i];
                }
            }
        }

        //Изменение кол-ва строк в таблице
        private void RowValue_ValueChanged(object sender, EventArgs e)
        {
            decided = false;
            dataGridView.RowCount = Convert.ToInt32(RowValue.Value);
            dataGridView.Rows[Convert.ToInt32(RowValue.Value) - 1].HeaderCell.Value = "E" + RowValue.Value.ToString();
        }


        //Видимости при режиме MM
        private void radioButtonMM_CheckedChanged(object sender, EventArgs e)
        {
            if (decided)
            {
                dataGridView.ColumnCount -= 1;
            }
            decided = false;
            if (radioButtonMM.Checked)
            {
                dataGridView1.Visible = false;
                dataGridView.Width = 670;
                numС.Visible = false;
                label_Gy.Visible = false;
                numHL.Visible = false;
                labelHL.Visible = false;
            }
        }

        //Видимости при режиме BL
        private void radioButtonBL_CheckedChanged(object sender, EventArgs e)
        {
            if (decided)
            {
                dataGridView.ColumnCount -= 1;
            }
            decided = false;
            if (radioButtonBL.Checked)
            {
                dataGridView1.Visible = true;
                dataGridView.Width = 519;
                numС.Visible = false;
                label_Gy.Visible = false;
                numHL.Visible = false;
                labelHL.Visible = false;
            }
        }

        //Видимости при режиме Gy
        private void radioButtonGy_CheckedChanged(object sender, EventArgs e)
        {
            if (decided)
            {
                dataGridView.ColumnCount -= 1;
            }
            decided = false;
            if (radioButtonGy.Checked)
            {
                dataGridView1.Visible = false;
                dataGridView.Width = 670;
                numС.Visible = true;
                label_Gy.Visible = true;
                numHL.Visible = false;
                labelHL.Visible = false;
            }
        }


        //Видимости при режиме HL
        private void radioButtonHL_CheckedChanged(object sender, EventArgs e)
        {
            if (decided)
            {
                dataGridView.ColumnCount -= 1;
            }
            decided = false;
            if (radioButtonHL.Checked)
            {
                dataGridView1.Visible = false;
                dataGridView.Width = 670;
                numС.Visible = false;
                label_Gy.Visible = false;
                numHL.Visible = true;
                labelHL.Visible = true;
            }
        }

        //Проверка на ошибки
        bool error()
        {
            if (radioButtonBL.Checked)
            {
                double summBL = 0;
                for (int i = 0; i < Convert.ToInt32(ColumnValue.Value); i++)
                {
                    summBL += Convert.ToDouble(dataGridView1[0, i].Value);
                }
                if (Math.Round(summBL, 3) != 1)
                {
                    MessageBox.Show("При использоании Критерия Байеса-Лапласа сумма вероятностей должна быть равна 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }

        }



        //кнопка ЗАДАЧА 1
        private void button1_Click_1(object sender, EventArgs e)
        {
            decided = false;
            Answer.Clear();
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

            numС.Value = Convert.ToDecimal(0.5);
            numHL.Value = Convert.ToDecimal(0.5);
        }

        //кнопка ЗАДАЧА 2
        private void button2_Click(object sender, EventArgs e)
        {
            decided = false;
            Answer.Clear();
            ColumnValue.Value = 1;
            RowValue.Value = 1;
            ColumnValue.Value = 2;
            RowValue.Value = 2;
            ColumnValue.Value = 3;
            RowValue.Value = 3;

            dataGridView[0, 0].Value = -50;
            dataGridView[1, 0].Value = -21;
            dataGridView[2, 0].Value = -23;
            dataGridView[0, 1].Value = -33;
            dataGridView[1, 1].Value = -11;
            dataGridView[2, 1].Value = 15;
            dataGridView[0, 2].Value = 0;
            dataGridView[1, 2].Value = 5;
            dataGridView[2, 2].Value = 10;

            dataGridView1[0, 0].Value = 0.3;
            dataGridView1[0, 1].Value = 0.5;
            dataGridView1[0, 2].Value = 0.2;

            numС.Value = Convert.ToDecimal(0.5);
            numHL.Value = Convert.ToDecimal(0.5);
        }

        //кнопка ЗАДАЧА 3
        private void button3_Click(object sender, EventArgs e)
        {
            decided = false;
            Answer.Clear();
            ColumnValue.Value = 1;
            RowValue.Value = 1;
            ColumnValue.Value = 2;
            RowValue.Value = 2;
            ColumnValue.Value = 3;
            RowValue.Value = 3;

            dataGridView[0, 0].Value = 54;
            dataGridView[1, 0].Value = 90;
            dataGridView[2, 0].Value = 15;
            dataGridView[0, 1].Value = 41;
            dataGridView[1, 1].Value = 52;
            dataGridView[2, 1].Value = 10;
            dataGridView[0, 2].Value = 29;
            dataGridView[1, 2].Value = 19;
            dataGridView[2, 2].Value = 7;

            dataGridView1[0, 0].Value = 0.3;
            dataGridView1[0, 1].Value = 0.5;
            dataGridView1[0, 2].Value = 0.2;

            numС.Value = Convert.ToDecimal(0.5);
            numHL.Value = Convert.ToDecimal(0.5);
        }

        //кнопка ЗАДАЧА 4
        private void button4_Click(object sender, EventArgs e)
        {
            decided = false;
            Answer.Clear();
            ColumnValue.Value = 1;
            RowValue.Value = 1;
            ColumnValue.Value = 2;
            RowValue.Value = 2;
            ColumnValue.Value = 3;
            RowValue.Value = 3;

            dataGridView[0, 0].Value = 94;
            dataGridView[1, 0].Value = 50;
            dataGridView[2, 0].Value = 18;
            dataGridView[0, 1].Value = 51;
            dataGridView[1, 1].Value = 27;
            dataGridView[2, 1].Value = 11;
            dataGridView[0, 2].Value = 19;
            dataGridView[1, 2].Value = 12;
            dataGridView[2, 2].Value = 7;

            dataGridView1[0, 0].Value = 0.2;
            dataGridView1[0, 1].Value = 0.5;
            dataGridView1[0, 2].Value = 0.3;

            numС.Value = Convert.ToDecimal(0.5);
            numHL.Value = Convert.ToDecimal(0.5);
        }
    }
}

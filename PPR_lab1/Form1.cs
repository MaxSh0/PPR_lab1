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
        }

        //Кнопка решить
        private void button1_Click(object sender, EventArgs e)
        {
            double[,] matrix = new double[2, 3];//[Convert.ToInt32(ColumnValue.Value), Convert.ToInt32(RowValue.Value)];
            Table_in_matrix(matrix);
            Answer.Text = MM(matrix);
        }

        //Метод выбора с использованием Минимаксного критерия
        string MM(double[,] matrix)
        {
            double cur_val;
            double[] arr_max;
            arr_max = min(matrix);
            double max = arr_max[0];
            for (int i = 0; i < arr_max.Length; i++)
            {
                cur_val = arr_max[i];
                if (max < cur_val)
                {
                    max = cur_val;
                }
            }
            return max.ToString();
        }








        //возвращает массив наименьших элементов в строках 2D массива
        double[] min(double[,] matrix)
        {
            double[] arr_min = new double[matrix.GetLength(0)];
            for (int n = 0; n < matrix.GetLength(0); n++)
            {
                arr_min[n] = matrix[0, n];
            }
            double cur_val;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
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

        // преобразует таблицу в 2D массив
        double[,] Table_in_matrix(double[,] matrix)
        {
            //matrix =(double[,]) ResizeArray(matrix, new int[] { Convert.ToInt32(ColumnValue.Value),Convert.ToInt32(RowValue.Value)});
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    matrix[i, j] =Convert.ToDouble(dataGridView[i, j].Value);
                }
            }
            return matrix;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Изменение кол-ва столбцов в таблице
        private void ColumnValue_ValueChanged(object sender, EventArgs e)
        {
            dataGridView.ColumnCount = Convert.ToInt32(ColumnValue.Value);
            dataGridView.Columns[Convert.ToInt32(ColumnValue.Value) - 1].HeaderText = "F" + ColumnValue.Value.ToString();
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

        }



        public static Array ResizeArray(Array arr, int[] newSizes)
        {
            if (newSizes.Length != arr.Rank)
                throw new ArgumentException("arr must have the same number of dimensions " +
                                            "as there are elements in newSizes", "newSizes");

            var temp = Array.CreateInstance(arr.GetType().GetElementType(), newSizes);
            int length = arr.Length <= temp.Length ? arr.Length : temp.Length;
            Array.ConstrainedCopy(arr, 0, temp, 0, length);
            return temp;
        }

    }
}

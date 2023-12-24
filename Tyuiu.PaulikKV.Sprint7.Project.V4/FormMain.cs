using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PaulikKV.Sprint7.Project.V4.Lib;
using System.IO;

namespace Tyuiu.PaulikKV.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogData_PKV.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static string openFilePath;
        static int rows;
        static int columns;
        static string[,] matrix;
        DataService ds = new DataService();
        private void buttonInfo_PKV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonHelp_PKV_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void buttonFile_PKV_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogData_PKV.ShowDialog();
                openFilePath = openFileDialogData_PKV.FileName;

                matrix = ds.LoadDataFromFile(openFilePath);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewTabl_PKV.Rows.Clear();
                dataGridViewTabl_PKV.Columns.Clear();
                dataGridViewTabl_PKV.RowCount = rows + 1;
                dataGridViewTabl_PKV.ColumnCount = columns + 10;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewTabl_PKV.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewTabl_PKV.Rows[i].Cells[j].Selected = false;
                    }
                }
                this.dataGridViewTabl_PKV.DefaultCellStyle.Font = new Font("Tahoma", 9);
                dataGridViewTabl_PKV.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


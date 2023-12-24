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
                dataGridViewTabl_PKV.ColumnCount = columns;

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

        private void buttonAdd_PKV_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewTabl_PKV.Rows.Add();
                for (int i = 0; i < dataGridViewTabl_PKV.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewTabl_PKV.ColumnCount - 1; j++)
                    {
                        dataGridViewTabl_PKV.Rows[i].Cells[j].Selected = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDel_PKV_Click(object sender, EventArgs e)
        {
            if (dataGridViewTabl_PKV.RowCount != 0)
            {
                int nugno = -1;
                for (int i = 0; i < dataGridViewTabl_PKV.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewTabl_PKV.ColumnCount - 1; j++)
                    {
                        if (dataGridViewTabl_PKV.Rows[i].Cells[j].Selected == true)
                        {
                            nugno = j;
                            break;
                        }
                    }
                    if (nugno > -1) break;
                }
                if (nugno > -1)
                {
                    if (dataGridViewTabl_PKV.Rows[0].Cells[nugno].Selected == true) MessageBox.Show("Первую строку нельзя удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        var result = MessageBox.Show($"{"Удалить данную строку?" + "\r"}{"Ее невозможно будет восстановить"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            int k = -1; int udal = 0;
                            for (int i = 1; i < dataGridViewTabl_PKV.RowCount - 1; i++)
                            {
                                if (dataGridViewTabl_PKV.Rows[i].Cells[nugno].Selected == true)
                                {
                                    k = i;
                                    break;
                                }
                                if (k > -1) break;
                            }
                            for (int i = 1; i < dataGridViewTabl_PKV.RowCount - 1; i++)
                            {
                                if (dataGridViewTabl_PKV.Rows[i].Cells[nugno].Selected == true) udal++;
                            }
                            for (int r = 0; r < udal; r++) dataGridViewTabl_PKV.Rows.Remove(dataGridViewTabl_PKV.Rows[k]);
                            for (int i = 0; i < dataGridViewTabl_PKV.RowCount - 1; i++)
                            {
                                for (int j = 0; j < dataGridViewTabl_PKV.ColumnCount - 1; j++)
                                {
                                    dataGridViewTabl_PKV.Rows[i].Cells[j].Selected = false;
                                }
                            }
                        }
                    }
                }
                else MessageBox.Show("Выберите строку, которую ходите удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonFile_PKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_PKV.SetToolTip(buttonFile_PKV, "Открыть файл");
        }

        private void buttonSave_PKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_PKV.SetToolTip(buttonSave_PKV, "Сохранить файл");
        }

        private void buttonGraf_PKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_PKV.SetToolTip(buttonGraf_PKV, "Открыть графики");
        }

        private void buttonHelp_PKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_PKV.SetToolTip(buttonHelp_PKV, "Ход реализации проекта");
        }

        private void buttonInfo_PKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_PKV.SetToolTip(buttonInfo_PKV, "Справка о разработчике");
        }

        static string[,] matrixFind;
        private void textBoxFind_PKV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < matrixFind.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < matrixFind.GetUpperBound(1); j++)
                    {
                        if (matrixFind[i, j] != null)
                        {
                            string elmnt = matrixFind[i, j].ToLower();
                            if (elmnt.Contains(textBoxFind_PKV.Text.ToLower())) dataGridViewTabl_PKV.Rows[i].Cells[j].Selected = true;
                        }
                    }
                }
            }
        }


        private void textBoxFind_PKV_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewTabl_PKV.RowCount != 0)
            {
                matrixFind = new string[dataGridViewTabl_PKV.RowCount + 1, dataGridViewTabl_PKV.ColumnCount + 1];
                for (int i = 0; i < matrixFind.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < matrixFind.GetUpperBound(1); j++)
                    {
                        matrixFind[i, j] = Convert.ToString(dataGridViewTabl_PKV.Rows[i].Cells[j].Value);
                        dataGridViewTabl_PKV.Rows[i].Cells[j].Selected = false;
                    }
                }

                textBoxKolvo_PKV.Text = "";
                textBoxSum_PKV.Text = "";
                textBoxSrznach_PKV.Text = "";
                textBoxMin_PKV.Text = "";
                textBoxMax_PKV.Text = "";
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSave_PKV_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogTask_PKV.FileName = "NewFileC#.csv";
                saveFileDialogTask_PKV.InitialDirectory = @"C:\Users\user\Desktop";
                if (saveFileDialogTask_PKV.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialogTask_PKV.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewTabl_PKV.RowCount;
                    int columns = dataGridViewTabl_PKV.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewTabl_PKV.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(",");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGraf_PKV_Click(object sender, EventArgs e)
        {
            FormChart formChart = new FormChart();
            formChart.ShowDialog();
        }
    }
}



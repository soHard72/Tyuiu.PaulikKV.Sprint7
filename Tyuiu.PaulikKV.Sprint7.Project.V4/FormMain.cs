using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PaulikKV.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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
            openFileDialogTask_PKV.ShowDialog();
            openFilePath = openFileDialogTask_PKV.FileName;
            textBoxInput_PKV.Text = File.ReadAllText(openFilePath);
            groupBoxInput_PKV.Text = groupBoxInput_PKV.Text + " " + openFileDialogTask_PKV.FileName;
            buttonDone_PKV.Enabled = true;
        }
    }
}

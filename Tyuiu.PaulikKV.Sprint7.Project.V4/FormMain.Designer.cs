﻿
namespace Tyuiu.PaulikKV.Sprint7.Project.V4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelBasic_PKV = new System.Windows.Forms.Panel();
            this.textBoxFind_PKV = new System.Windows.Forms.TextBox();
            this.labelFind_PKV = new System.Windows.Forms.Label();
            this.buttonSave_PKV = new System.Windows.Forms.Button();
            this.groupBoxFiltr_PKV = new System.Windows.Forms.GroupBox();
            this.comboBoxFiltr_PKV = new System.Windows.Forms.ComboBox();
            this.buttonDelFiltr_PKV = new System.Windows.Forms.Button();
            this.groupBoxSort_PKV = new System.Windows.Forms.GroupBox();
            this.comboBoxSort_PKV = new System.Windows.Forms.ComboBox();
            this.buttonDelSort_PKV = new System.Windows.Forms.Button();
            this.dataGridViewTabl_PKV = new System.Windows.Forms.DataGridView();
            this.buttonInfo_PKV = new System.Windows.Forms.Button();
            this.buttonHelp_PKV = new System.Windows.Forms.Button();
            this.buttonGraf_PKV = new System.Windows.Forms.Button();
            this.buttonFile_PKV = new System.Windows.Forms.Button();
            this.panelInfo_PKV = new System.Windows.Forms.Panel();
            this.buttonDel_PKV = new System.Windows.Forms.Button();
            this.buttonAdd_PKV = new System.Windows.Forms.Button();
            this.groupBoxData_PKV = new System.Windows.Forms.GroupBox();
            this.textBoxMax_PKV = new System.Windows.Forms.TextBox();
            this.textBoxMin_PKV = new System.Windows.Forms.TextBox();
            this.textBoxSrznach_PKV = new System.Windows.Forms.TextBox();
            this.textBoxSum_PKV = new System.Windows.Forms.TextBox();
            this.textBoxKolvo_PKV = new System.Windows.Forms.TextBox();
            this.labelMax_PKV = new System.Windows.Forms.Label();
            this.labelMin_PKV = new System.Windows.Forms.Label();
            this.labelSrznach_PKV = new System.Windows.Forms.Label();
            this.labelSum_PKV = new System.Windows.Forms.Label();
            this.labelKolvo_PKV = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolTipProject_PKV = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogData_PKV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask_PKV = new System.Windows.Forms.SaveFileDialog();
            this.panelBasic_PKV.SuspendLayout();
            this.groupBoxFiltr_PKV.SuspendLayout();
            this.groupBoxSort_PKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabl_PKV)).BeginInit();
            this.panelInfo_PKV.SuspendLayout();
            this.groupBoxData_PKV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBasic_PKV
            // 
            this.panelBasic_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBasic_PKV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBasic_PKV.Controls.Add(this.textBoxFind_PKV);
            this.panelBasic_PKV.Controls.Add(this.labelFind_PKV);
            this.panelBasic_PKV.Controls.Add(this.buttonSave_PKV);
            this.panelBasic_PKV.Controls.Add(this.groupBoxFiltr_PKV);
            this.panelBasic_PKV.Controls.Add(this.groupBoxSort_PKV);
            this.panelBasic_PKV.Controls.Add(this.dataGridViewTabl_PKV);
            this.panelBasic_PKV.Controls.Add(this.buttonInfo_PKV);
            this.panelBasic_PKV.Controls.Add(this.buttonHelp_PKV);
            this.panelBasic_PKV.Controls.Add(this.buttonGraf_PKV);
            this.panelBasic_PKV.Controls.Add(this.buttonFile_PKV);
            this.panelBasic_PKV.Location = new System.Drawing.Point(2, 2);
            this.panelBasic_PKV.Name = "panelBasic_PKV";
            this.panelBasic_PKV.Size = new System.Drawing.Size(1314, 555);
            this.panelBasic_PKV.TabIndex = 0;
            // 
            // textBoxFind_PKV
            // 
            this.textBoxFind_PKV.Location = new System.Drawing.Point(75, 65);
            this.textBoxFind_PKV.Name = "textBoxFind_PKV";
            this.textBoxFind_PKV.Size = new System.Drawing.Size(345, 22);
            this.textBoxFind_PKV.TabIndex = 9;
            this.textBoxFind_PKV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFind_PKV_KeyDown);
            this.textBoxFind_PKV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxFind_PKV_KeyUp);
            // 
            // labelFind_PKV
            // 
            this.labelFind_PKV.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelFind_PKV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFind_PKV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFind_PKV.Location = new System.Drawing.Point(20, 65);
            this.labelFind_PKV.Name = "labelFind_PKV";
            this.labelFind_PKV.Size = new System.Drawing.Size(53, 22);
            this.labelFind_PKV.TabIndex = 8;
            this.labelFind_PKV.Text = "Поиск";
            // 
            // buttonSave_PKV
            // 
            this.buttonSave_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_PKV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSave_PKV.Location = new System.Drawing.Point(164, 10);
            this.buttonSave_PKV.Name = "buttonSave_PKV";
            this.buttonSave_PKV.Size = new System.Drawing.Size(112, 36);
            this.buttonSave_PKV.TabIndex = 7;
            this.buttonSave_PKV.Text = "Сохранить";
            this.buttonSave_PKV.UseVisualStyleBackColor = true;
            this.buttonSave_PKV.Click += new System.EventHandler(this.buttonSave_PKV_Click);
            this.buttonSave_PKV.MouseEnter += new System.EventHandler(this.buttonSave_PKV_MouseEnter);
            // 
            // groupBoxFiltr_PKV
            // 
            this.groupBoxFiltr_PKV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxFiltr_PKV.AutoSize = true;
            this.groupBoxFiltr_PKV.Controls.Add(this.comboBoxFiltr_PKV);
            this.groupBoxFiltr_PKV.Controls.Add(this.buttonDelFiltr_PKV);
            this.groupBoxFiltr_PKV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFiltr_PKV.ForeColor = System.Drawing.Color.LightGray;
            this.groupBoxFiltr_PKV.Location = new System.Drawing.Point(977, 357);
            this.groupBoxFiltr_PKV.Name = "groupBoxFiltr_PKV";
            this.groupBoxFiltr_PKV.Size = new System.Drawing.Size(307, 161);
            this.groupBoxFiltr_PKV.TabIndex = 6;
            this.groupBoxFiltr_PKV.TabStop = false;
            this.groupBoxFiltr_PKV.Text = "Фильтрация";
            // 
            // comboBoxFiltr_PKV
            // 
            this.comboBoxFiltr_PKV.FormattingEnabled = true;
            this.comboBoxFiltr_PKV.Location = new System.Drawing.Point(22, 43);
            this.comboBoxFiltr_PKV.Name = "comboBoxFiltr_PKV";
            this.comboBoxFiltr_PKV.Size = new System.Drawing.Size(255, 26);
            this.comboBoxFiltr_PKV.TabIndex = 1;
            // 
            // buttonDelFiltr_PKV
            // 
            this.buttonDelFiltr_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelFiltr_PKV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDelFiltr_PKV.ForeColor = System.Drawing.Color.Black;
            this.buttonDelFiltr_PKV.Location = new System.Drawing.Point(74, 110);
            this.buttonDelFiltr_PKV.Name = "buttonDelFiltr_PKV";
            this.buttonDelFiltr_PKV.Size = new System.Drawing.Size(160, 28);
            this.buttonDelFiltr_PKV.TabIndex = 0;
            this.buttonDelFiltr_PKV.Text = "Убрать фильтр";
            this.buttonDelFiltr_PKV.UseVisualStyleBackColor = true;
            // 
            // groupBoxSort_PKV
            // 
            this.groupBoxSort_PKV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxSort_PKV.AutoSize = true;
            this.groupBoxSort_PKV.Controls.Add(this.comboBoxSort_PKV);
            this.groupBoxSort_PKV.Controls.Add(this.buttonDelSort_PKV);
            this.groupBoxSort_PKV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSort_PKV.ForeColor = System.Drawing.Color.LightGray;
            this.groupBoxSort_PKV.Location = new System.Drawing.Point(977, 118);
            this.groupBoxSort_PKV.Name = "groupBoxSort_PKV";
            this.groupBoxSort_PKV.Size = new System.Drawing.Size(307, 164);
            this.groupBoxSort_PKV.TabIndex = 5;
            this.groupBoxSort_PKV.TabStop = false;
            this.groupBoxSort_PKV.Text = "Сортировка";
            // 
            // comboBoxSort_PKV
            // 
            this.comboBoxSort_PKV.FormattingEnabled = true;
            this.comboBoxSort_PKV.Location = new System.Drawing.Point(22, 43);
            this.comboBoxSort_PKV.Name = "comboBoxSort_PKV";
            this.comboBoxSort_PKV.Size = new System.Drawing.Size(255, 26);
            this.comboBoxSort_PKV.TabIndex = 2;
            // 
            // buttonDelSort_PKV
            // 
            this.buttonDelSort_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelSort_PKV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDelSort_PKV.ForeColor = System.Drawing.Color.Black;
            this.buttonDelSort_PKV.Location = new System.Drawing.Point(74, 110);
            this.buttonDelSort_PKV.Name = "buttonDelSort_PKV";
            this.buttonDelSort_PKV.Size = new System.Drawing.Size(160, 26);
            this.buttonDelSort_PKV.TabIndex = 0;
            this.buttonDelSort_PKV.Text = "Убрать сортировку";
            this.buttonDelSort_PKV.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTabl_PKV
            // 
            this.dataGridViewTabl_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTabl_PKV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabl_PKV.Location = new System.Drawing.Point(10, 94);
            this.dataGridViewTabl_PKV.Name = "dataGridViewTabl_PKV";
            this.dataGridViewTabl_PKV.ReadOnly = true;
            this.dataGridViewTabl_PKV.RowHeadersWidth = 51;
            this.dataGridViewTabl_PKV.RowTemplate.Height = 24;
            this.dataGridViewTabl_PKV.Size = new System.Drawing.Size(939, 455);
            this.dataGridViewTabl_PKV.TabIndex = 4;
            // 
            // buttonInfo_PKV
            // 
            this.buttonInfo_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_PKV.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonInfo_PKV.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonInfo_PKV.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonInfo_PKV.FlatAppearance.BorderSize = 3;
            this.buttonInfo_PKV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_PKV.ForeColor = System.Drawing.Color.Black;
            this.buttonInfo_PKV.Location = new System.Drawing.Point(1259, 10);
            this.buttonInfo_PKV.Name = "buttonInfo_PKV";
            this.buttonInfo_PKV.Size = new System.Drawing.Size(45, 36);
            this.buttonInfo_PKV.TabIndex = 3;
            this.buttonInfo_PKV.Text = "?";
            this.buttonInfo_PKV.UseVisualStyleBackColor = false;
            this.buttonInfo_PKV.Click += new System.EventHandler(this.buttonInfo_PKV_Click);
            this.buttonInfo_PKV.MouseEnter += new System.EventHandler(this.buttonInfo_PKV_MouseEnter);
            // 
            // buttonHelp_PKV
            // 
            this.buttonHelp_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_PKV.Location = new System.Drawing.Point(458, 10);
            this.buttonHelp_PKV.Name = "buttonHelp_PKV";
            this.buttonHelp_PKV.Size = new System.Drawing.Size(170, 36);
            this.buttonHelp_PKV.TabIndex = 2;
            this.buttonHelp_PKV.Text = "Краткое руководство";
            this.buttonHelp_PKV.UseVisualStyleBackColor = true;
            this.buttonHelp_PKV.Click += new System.EventHandler(this.buttonHelp_PKV_Click);
            this.buttonHelp_PKV.MouseEnter += new System.EventHandler(this.buttonHelp_PKV_MouseEnter);
            // 
            // buttonGraf_PKV
            // 
            this.buttonGraf_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGraf_PKV.Location = new System.Drawing.Point(313, 10);
            this.buttonGraf_PKV.Name = "buttonGraf_PKV";
            this.buttonGraf_PKV.Size = new System.Drawing.Size(107, 35);
            this.buttonGraf_PKV.TabIndex = 1;
            this.buttonGraf_PKV.Text = "Графики";
            this.buttonGraf_PKV.UseVisualStyleBackColor = true;
            this.buttonGraf_PKV.Click += new System.EventHandler(this.buttonGraf_PKV_Click);
            this.buttonGraf_PKV.MouseEnter += new System.EventHandler(this.buttonGraf_PKV_MouseEnter);
            // 
            // buttonFile_PKV
            // 
            this.buttonFile_PKV.BackColor = System.Drawing.Color.White;
            this.buttonFile_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFile_PKV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonFile_PKV.Location = new System.Drawing.Point(19, 10);
            this.buttonFile_PKV.Name = "buttonFile_PKV";
            this.buttonFile_PKV.Size = new System.Drawing.Size(109, 35);
            this.buttonFile_PKV.TabIndex = 0;
            this.buttonFile_PKV.Text = "Файл";
            this.buttonFile_PKV.UseVisualStyleBackColor = false;
            this.buttonFile_PKV.Click += new System.EventHandler(this.buttonFile_PKV_Click);
            this.buttonFile_PKV.MouseEnter += new System.EventHandler(this.buttonFile_PKV_MouseEnter);
            // 
            // panelInfo_PKV
            // 
            this.panelInfo_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo_PKV.BackColor = System.Drawing.Color.Gray;
            this.panelInfo_PKV.Controls.Add(this.buttonDel_PKV);
            this.panelInfo_PKV.Controls.Add(this.buttonAdd_PKV);
            this.panelInfo_PKV.Controls.Add(this.groupBoxData_PKV);
            this.panelInfo_PKV.Controls.Add(this.splitter1);
            this.panelInfo_PKV.Location = new System.Drawing.Point(2, 557);
            this.panelInfo_PKV.Name = "panelInfo_PKV";
            this.panelInfo_PKV.Size = new System.Drawing.Size(1314, 140);
            this.panelInfo_PKV.TabIndex = 1;
            // 
            // buttonDel_PKV
            // 
            this.buttonDel_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDel_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel_PKV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDel_PKV.Location = new System.Drawing.Point(1077, 72);
            this.buttonDel_PKV.Name = "buttonDel_PKV";
            this.buttonDel_PKV.Size = new System.Drawing.Size(134, 36);
            this.buttonDel_PKV.TabIndex = 3;
            this.buttonDel_PKV.Text = "Удалить";
            this.buttonDel_PKV.UseVisualStyleBackColor = true;
            this.buttonDel_PKV.Click += new System.EventHandler(this.buttonDel_PKV_Click);
            // 
            // buttonAdd_PKV
            // 
            this.buttonAdd_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd_PKV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAdd_PKV.Location = new System.Drawing.Point(1077, 27);
            this.buttonAdd_PKV.Name = "buttonAdd_PKV";
            this.buttonAdd_PKV.Size = new System.Drawing.Size(134, 34);
            this.buttonAdd_PKV.TabIndex = 2;
            this.buttonAdd_PKV.Text = "Добавить";
            this.buttonAdd_PKV.UseVisualStyleBackColor = true;
            this.buttonAdd_PKV.Click += new System.EventHandler(this.buttonAdd_PKV_Click);
            // 
            // groupBoxData_PKV
            // 
            this.groupBoxData_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxData_PKV.Controls.Add(this.textBoxMax_PKV);
            this.groupBoxData_PKV.Controls.Add(this.textBoxMin_PKV);
            this.groupBoxData_PKV.Controls.Add(this.textBoxSrznach_PKV);
            this.groupBoxData_PKV.Controls.Add(this.textBoxSum_PKV);
            this.groupBoxData_PKV.Controls.Add(this.textBoxKolvo_PKV);
            this.groupBoxData_PKV.Controls.Add(this.labelMax_PKV);
            this.groupBoxData_PKV.Controls.Add(this.labelMin_PKV);
            this.groupBoxData_PKV.Controls.Add(this.labelSrznach_PKV);
            this.groupBoxData_PKV.Controls.Add(this.labelSum_PKV);
            this.groupBoxData_PKV.Controls.Add(this.labelKolvo_PKV);
            this.groupBoxData_PKV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxData_PKV.ForeColor = System.Drawing.Color.White;
            this.groupBoxData_PKV.Location = new System.Drawing.Point(11, 7);
            this.groupBoxData_PKV.Name = "groupBoxData_PKV";
            this.groupBoxData_PKV.Size = new System.Drawing.Size(938, 115);
            this.groupBoxData_PKV.TabIndex = 1;
            this.groupBoxData_PKV.TabStop = false;
            this.groupBoxData_PKV.Text = "Статические данные";
            // 
            // textBoxMax_PKV
            // 
            this.textBoxMax_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMax_PKV.Location = new System.Drawing.Point(742, 49);
            this.textBoxMax_PKV.Name = "textBoxMax_PKV";
            this.textBoxMax_PKV.Size = new System.Drawing.Size(100, 26);
            this.textBoxMax_PKV.TabIndex = 9;
            this.textBoxMax_PKV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMax_PKV_KeyUp);
            // 
            // textBoxMin_PKV
            // 
            this.textBoxMin_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMin_PKV.Location = new System.Drawing.Point(569, 49);
            this.textBoxMin_PKV.Name = "textBoxMin_PKV";
            this.textBoxMin_PKV.Size = new System.Drawing.Size(100, 26);
            this.textBoxMin_PKV.TabIndex = 8;
            this.textBoxMin_PKV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMin_PKV_KeyUp);
            // 
            // textBoxSrznach_PKV
            // 
            this.textBoxSrznach_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSrznach_PKV.Location = new System.Drawing.Point(378, 49);
            this.textBoxSrznach_PKV.Name = "textBoxSrznach_PKV";
            this.textBoxSrznach_PKV.Size = new System.Drawing.Size(100, 26);
            this.textBoxSrznach_PKV.TabIndex = 7;
            this.textBoxSrznach_PKV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSrznach_PKV_KeyUp);
            // 
            // textBoxSum_PKV
            // 
            this.textBoxSum_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSum_PKV.Location = new System.Drawing.Point(186, 49);
            this.textBoxSum_PKV.Name = "textBoxSum_PKV";
            this.textBoxSum_PKV.Size = new System.Drawing.Size(140, 26);
            this.textBoxSum_PKV.TabIndex = 6;
            this.textBoxSum_PKV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSum_PKV_KeyUp);
            // 
            // textBoxKolvo_PKV
            // 
            this.textBoxKolvo_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKolvo_PKV.Location = new System.Drawing.Point(35, 49);
            this.textBoxKolvo_PKV.Name = "textBoxKolvo_PKV";
            this.textBoxKolvo_PKV.Size = new System.Drawing.Size(100, 26);
            this.textBoxKolvo_PKV.TabIndex = 5;
            this.textBoxKolvo_PKV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxKolvo_PKV_KeyUp);
            // 
            // labelMax_PKV
            // 
            this.labelMax_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMax_PKV.AutoSize = true;
            this.labelMax_PKV.Location = new System.Drawing.Point(725, 27);
            this.labelMax_PKV.Name = "labelMax_PKV";
            this.labelMax_PKV.Size = new System.Drawing.Size(134, 20);
            this.labelMax_PKV.TabIndex = 4;
            this.labelMax_PKV.Text = "Макс.значение";
            // 
            // labelMin_PKV
            // 
            this.labelMin_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMin_PKV.AutoSize = true;
            this.labelMin_PKV.Location = new System.Drawing.Point(556, 27);
            this.labelMin_PKV.Name = "labelMin_PKV";
            this.labelMin_PKV.Size = new System.Drawing.Size(126, 20);
            this.labelMin_PKV.TabIndex = 3;
            this.labelMin_PKV.Text = "Мин.значение";
            // 
            // labelSrznach_PKV
            // 
            this.labelSrznach_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSrznach_PKV.AutoSize = true;
            this.labelSrznach_PKV.Location = new System.Drawing.Point(347, 27);
            this.labelSrznach_PKV.Name = "labelSrznach_PKV";
            this.labelSrznach_PKV.Size = new System.Drawing.Size(167, 20);
            this.labelSrznach_PKV.TabIndex = 2;
            this.labelSrznach_PKV.Text = "Среднее значение";
            // 
            // labelSum_PKV
            // 
            this.labelSum_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSum_PKV.AutoSize = true;
            this.labelSum_PKV.Location = new System.Drawing.Point(230, 27);
            this.labelSum_PKV.Name = "labelSum_PKV";
            this.labelSum_PKV.Size = new System.Drawing.Size(63, 20);
            this.labelSum_PKV.TabIndex = 1;
            this.labelSum_PKV.Text = "Сумма";
            // 
            // labelKolvo_PKV
            // 
            this.labelKolvo_PKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKolvo_PKV.AutoSize = true;
            this.labelKolvo_PKV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelKolvo_PKV.Location = new System.Drawing.Point(8, 26);
            this.labelKolvo_PKV.Name = "labelKolvo_PKV";
            this.labelKolvo_PKV.Size = new System.Drawing.Size(162, 20);
            this.labelKolvo_PKV.TabIndex = 0;
            this.labelKolvo_PKV.Text = "Количество строк";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 140);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // toolTipProject_PKV
            // 
            this.toolTipProject_PKV.Tag = "";
            this.toolTipProject_PKV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipProject_PKV.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogData_PKV
            // 
            this.openFileDialogData_PKV.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 691);
            this.Controls.Add(this.panelInfo_PKV);
            this.Controls.Add(this.panelBasic_PKV);
            this.MinimumSize = new System.Drawing.Size(1336, 738);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.panelBasic_PKV.ResumeLayout(false);
            this.panelBasic_PKV.PerformLayout();
            this.groupBoxFiltr_PKV.ResumeLayout(false);
            this.groupBoxSort_PKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabl_PKV)).EndInit();
            this.panelInfo_PKV.ResumeLayout(false);
            this.groupBoxData_PKV.ResumeLayout(false);
            this.groupBoxData_PKV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBasic_PKV;
        private System.Windows.Forms.Panel panelInfo_PKV;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonInfo_PKV;
        private System.Windows.Forms.Button buttonHelp_PKV;
        private System.Windows.Forms.Button buttonGraf_PKV;
        private System.Windows.Forms.Button buttonFile_PKV;
        private System.Windows.Forms.GroupBox groupBoxFiltr_PKV;
        private System.Windows.Forms.GroupBox groupBoxSort_PKV;
        private System.Windows.Forms.DataGridView dataGridViewTabl_PKV;
        private System.Windows.Forms.GroupBox groupBoxData_PKV;
        private System.Windows.Forms.Button buttonDelFiltr_PKV;
        private System.Windows.Forms.Button buttonDelSort_PKV;
        private System.Windows.Forms.Button buttonDel_PKV;
        private System.Windows.Forms.Button buttonAdd_PKV;
        private System.Windows.Forms.Label labelMax_PKV;
        private System.Windows.Forms.Label labelMin_PKV;
        private System.Windows.Forms.Label labelSrznach_PKV;
        private System.Windows.Forms.Label labelSum_PKV;
        private System.Windows.Forms.Label labelKolvo_PKV;
        private System.Windows.Forms.TextBox textBoxMax_PKV;
        private System.Windows.Forms.TextBox textBoxMin_PKV;
        private System.Windows.Forms.TextBox textBoxSrznach_PKV;
        private System.Windows.Forms.TextBox textBoxSum_PKV;
        private System.Windows.Forms.TextBox textBoxKolvo_PKV;
        private System.Windows.Forms.ToolTip toolTipProject_PKV;
        private System.Windows.Forms.OpenFileDialog openFileDialogData_PKV;
        private System.Windows.Forms.Button buttonSave_PKV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_PKV;
        private System.Windows.Forms.TextBox textBoxFind_PKV;
        private System.Windows.Forms.Label labelFind_PKV;
        private System.Windows.Forms.ComboBox comboBoxFiltr_PKV;
        private System.Windows.Forms.ComboBox comboBoxSort_PKV;
    }
}


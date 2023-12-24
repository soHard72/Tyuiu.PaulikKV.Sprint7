
namespace Tyuiu.PaulikKV.Sprint7.Project.V4
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonCloseChart_PKV = new System.Windows.Forms.Button();
            this.chartFunc_PKV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_PKV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCloseChart_PKV
            // 
            this.buttonCloseChart_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseChart_PKV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCloseChart_PKV.Location = new System.Drawing.Point(666, 367);
            this.buttonCloseChart_PKV.Name = "buttonCloseChart_PKV";
            this.buttonCloseChart_PKV.Size = new System.Drawing.Size(122, 34);
            this.buttonCloseChart_PKV.TabIndex = 0;
            this.buttonCloseChart_PKV.Text = "OK";
            this.buttonCloseChart_PKV.UseVisualStyleBackColor = true;
            this.buttonCloseChart_PKV.Click += new System.EventHandler(this.buttonCloseChart_PKV_Click);
            // 
            // chartFunc_PKV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunc_PKV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunc_PKV.Legends.Add(legend1);
            this.chartFunc_PKV.Location = new System.Drawing.Point(12, -2);
            this.chartFunc_PKV.Name = "chartFunc_PKV";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunc_PKV.Series.Add(series1);
            this.chartFunc_PKV.Size = new System.Drawing.Size(775, 363);
            this.chartFunc_PKV.TabIndex = 1;
            this.chartFunc_PKV.Text = "chart1";
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.chartFunc_PKV);
            this.Controls.Add(this.buttonCloseChart_PKV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormChart";
            this.Text = "Графики";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_PKV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseChart_PKV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_PKV;
    }
}
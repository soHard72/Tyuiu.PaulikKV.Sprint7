
namespace Tyuiu.PaulikKV.Sprint7.Project.V4
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.buttonCloseGuide_PKV = new System.Windows.Forms.Button();
            this.textBoxGuide_PKV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCloseGuide_PKV
            // 
            this.buttonCloseGuide_PKV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCloseGuide_PKV.FlatAppearance.BorderSize = 5;
            this.buttonCloseGuide_PKV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCloseGuide_PKV.Location = new System.Drawing.Point(328, 172);
            this.buttonCloseGuide_PKV.Name = "buttonCloseGuide_PKV";
            this.buttonCloseGuide_PKV.Size = new System.Drawing.Size(100, 30);
            this.buttonCloseGuide_PKV.TabIndex = 0;
            this.buttonCloseGuide_PKV.Text = "OK";
            this.buttonCloseGuide_PKV.UseVisualStyleBackColor = true;
            this.buttonCloseGuide_PKV.Click += new System.EventHandler(this.buttonCloseGuide_PKV_Click);
            // 
            // textBoxGuide_PKV
            // 
            this.textBoxGuide_PKV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGuide_PKV.Location = new System.Drawing.Point(12, 12);
            this.textBoxGuide_PKV.Multiline = true;
            this.textBoxGuide_PKV.Name = "textBoxGuide_PKV";
            this.textBoxGuide_PKV.ReadOnly = true;
            this.textBoxGuide_PKV.Size = new System.Drawing.Size(416, 154);
            this.textBoxGuide_PKV.TabIndex = 1;
            this.textBoxGuide_PKV.Text = resources.GetString("textBoxGuide_PKV.Text");
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 207);
            this.Controls.Add(this.textBoxGuide_PKV);
            this.Controls.Add(this.buttonCloseGuide_PKV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Краткое руководство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseGuide_PKV;
        private System.Windows.Forms.TextBox textBoxGuide_PKV;
    }
}
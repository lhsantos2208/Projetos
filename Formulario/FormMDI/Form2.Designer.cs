﻿namespace FormMDI
{
    partial class Form2
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
            this.bntForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntForm3
            // 
            this.bntForm3.Location = new System.Drawing.Point(275, 164);
            this.bntForm3.Name = "bntForm3";
            this.bntForm3.Size = new System.Drawing.Size(258, 73);
            this.bntForm3.TabIndex = 0;
            this.bntForm3.Text = "Form3";
            this.bntForm3.UseVisualStyleBackColor = true;
            this.bntForm3.Click += new System.EventHandler(this.bntForm3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntForm3);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntForm3;
    }
}
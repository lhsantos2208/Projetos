namespace FormMDI
{
    partial class Form3
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
            this.bntForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntForm2
            // 
            this.bntForm2.Location = new System.Drawing.Point(271, 189);
            this.bntForm2.Name = "bntForm2";
            this.bntForm2.Size = new System.Drawing.Size(258, 73);
            this.bntForm2.TabIndex = 1;
            this.bntForm2.Text = "Form2";
            this.bntForm2.UseVisualStyleBackColor = true;
            this.bntForm2.Click += new System.EventHandler(this.bntForm2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntForm2);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntForm2;
    }
}
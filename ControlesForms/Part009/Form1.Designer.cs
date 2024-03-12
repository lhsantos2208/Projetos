namespace Part009
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbllink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbllink
            // 
            this.lbllink.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllink.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.lbllink.LinkColor = System.Drawing.Color.DarkRed;
            this.lbllink.Location = new System.Drawing.Point(13, 13);
            this.lbllink.Name = "lbllink";
            this.lbllink.Size = new System.Drawing.Size(775, 44);
            this.lbllink.TabIndex = 0;
            this.lbllink.TabStop = true;
            this.lbllink.Text = "Cursor de C#";
            this.lbllink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllink);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbllink;
    }
}


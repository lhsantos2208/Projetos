namespace ClassesImportantes
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
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btAleatorio = new System.Windows.Forms.Button();
            this.btnTimeSpan = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.brnFont = new System.Windows.Forms.Button();
            this.btnEnvironment = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageBox.Location = new System.Drawing.Point(12, 375);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(187, 63);
            this.btnMessageBox.TabIndex = 0;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(13, 13);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(775, 359);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "label1";
            // 
            // btAleatorio
            // 
            this.btAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAleatorio.Location = new System.Drawing.Point(205, 375);
            this.btAleatorio.Name = "btAleatorio";
            this.btAleatorio.Size = new System.Drawing.Size(187, 63);
            this.btAleatorio.TabIndex = 2;
            this.btAleatorio.Text = "Aleatório";
            this.btAleatorio.UseVisualStyleBackColor = true;
            this.btAleatorio.Click += new System.EventHandler(this.btAleatorio_Click);
            // 
            // btnTimeSpan
            // 
            this.btnTimeSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeSpan.Location = new System.Drawing.Point(398, 375);
            this.btnTimeSpan.Name = "btnTimeSpan";
            this.btnTimeSpan.Size = new System.Drawing.Size(187, 63);
            this.btnTimeSpan.TabIndex = 3;
            this.btnTimeSpan.Text = "TimeSpan";
            this.btnTimeSpan.UseVisualStyleBackColor = true;
            this.btnTimeSpan.Click += new System.EventHandler(this.btnTimeSpan_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateTime.Location = new System.Drawing.Point(591, 375);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(187, 63);
            this.btnDateTime.TabIndex = 4;
            this.btnDateTime.Text = "DateTime";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(12, 444);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(187, 63);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // brnFont
            // 
            this.brnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnFont.Location = new System.Drawing.Point(205, 444);
            this.brnFont.Name = "brnFont";
            this.brnFont.Size = new System.Drawing.Size(187, 63);
            this.brnFont.TabIndex = 6;
            this.brnFont.Text = "Font";
            this.brnFont.UseVisualStyleBackColor = true;
            this.brnFont.Click += new System.EventHandler(this.brnFont_Click);
            // 
            // btnEnvironment
            // 
            this.btnEnvironment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvironment.Location = new System.Drawing.Point(398, 444);
            this.btnEnvironment.Name = "btnEnvironment";
            this.btnEnvironment.Size = new System.Drawing.Size(187, 63);
            this.btnEnvironment.TabIndex = 7;
            this.btnEnvironment.Text = "Environment";
            this.btnEnvironment.UseVisualStyleBackColor = true;
            this.btnEnvironment.Click += new System.EventHandler(this.btnEnvironment_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplication.Location = new System.Drawing.Point(591, 444);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(187, 63);
            this.btnApplication.TabIndex = 8;
            this.btnApplication.Text = "Application";
            this.btnApplication.UseVisualStyleBackColor = true;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.btnApplication);
            this.Controls.Add(this.btnEnvironment);
            this.Controls.Add(this.brnFont);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.btnTimeSpan);
            this.Controls.Add(this.btAleatorio);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnMessageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btAleatorio;
        private System.Windows.Forms.Button btnTimeSpan;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button brnFont;
        private System.Windows.Forms.Button btnEnvironment;
        private System.Windows.Forms.Button btnApplication;
    }
}


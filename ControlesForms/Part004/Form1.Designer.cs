namespace Part004
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnRemoverIndice = new System.Windows.Forms.Button();
            this.BtnQuatidadeItens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Lista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lista.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lista.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 29;
            this.Lista.Location = new System.Drawing.Point(300, 0);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(500, 450);
            this.Lista.Sorted = true;
            this.Lista.TabIndex = 0;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(12, 54);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(282, 63);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(282, 35);
            this.txtNome.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 123);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(282, 63);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(12, 192);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(282, 63);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover Item";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnRemoverIndice
            // 
            this.btnRemoverIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverIndice.Location = new System.Drawing.Point(12, 261);
            this.btnRemoverIndice.Name = "btnRemoverIndice";
            this.btnRemoverIndice.Size = new System.Drawing.Size(282, 63);
            this.btnRemoverIndice.TabIndex = 5;
            this.btnRemoverIndice.Text = "Remover Item do Indice";
            this.btnRemoverIndice.UseVisualStyleBackColor = true;
            this.btnRemoverIndice.Click += new System.EventHandler(this.btnRemoverIndice_Click);
            // 
            // BtnQuatidadeItens
            // 
            this.BtnQuatidadeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuatidadeItens.Location = new System.Drawing.Point(12, 330);
            this.BtnQuatidadeItens.Name = "BtnQuatidadeItens";
            this.BtnQuatidadeItens.Size = new System.Drawing.Size(282, 63);
            this.BtnQuatidadeItens.TabIndex = 6;
            this.BtnQuatidadeItens.Text = "Quantidade de Itens";
            this.BtnQuatidadeItens.UseVisualStyleBackColor = true;
            this.BtnQuatidadeItens.Click += new System.EventHandler(this.BtnQuatidadeItens_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnQuatidadeItens);
            this.Controls.Add(this.btnRemoverIndice);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.Lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnRemoverIndice;
        private System.Windows.Forms.Button BtnQuatidadeItens;
    }
}


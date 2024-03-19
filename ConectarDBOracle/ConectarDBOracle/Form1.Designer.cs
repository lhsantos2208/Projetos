namespace ConectarDBOracle
{
    partial class frmDbOracle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            btnSalvar = new Button();
            btnConsultar = new Button();
            btnExcluir = new Button();
            dataGridView1 = new DataGridView();
            btnConsultaGeral = new Button();
            btnCrip = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(28, 22);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(92, 14);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(28, 58);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(92, 50);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(392, 23);
            txtDescricao.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(130, 79);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(292, 79);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(211, 79);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(456, 415);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnConsultaGeral
            // 
            btnConsultaGeral.Location = new Point(373, 79);
            btnConsultaGeral.Name = "btnConsultaGeral";
            btnConsultaGeral.Size = new Size(111, 23);
            btnConsultaGeral.TabIndex = 8;
            btnConsultaGeral.Text = "Consultar Geral";
            btnConsultaGeral.UseVisualStyleBackColor = true;
            btnConsultaGeral.Click += btnConsultaGeral_Click;
            // 
            // btnCrip
            // 
            btnCrip.Location = new Point(28, 79);
            btnCrip.Name = "btnCrip";
            btnCrip.Size = new Size(75, 23);
            btnCrip.TabIndex = 9;
            btnCrip.Text = "Criptografar";
            btnCrip.UseVisualStyleBackColor = true;
            btnCrip.Click += btnCrip_Click;
            // 
            // frmDbOracle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 535);
            Controls.Add(btnCrip);
            Controls.Add(btnConsultaGeral);
            Controls.Add(dataGridView1);
            Controls.Add(btnExcluir);
            Controls.Add(btnConsultar);
            Controls.Add(btnSalvar);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            MaximizeBox = false;
            Name = "frmDbOracle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conexão DB Oracle";
            FormClosed += frmDbOracle_FormClosed;
            Load += frmDbOracle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblDescricao;
        private Button btnSalvar;
        public Button btnConsultar;
        public TextBox txtCodigo;
        public TextBox txtDescricao;
        private Button btnExcluir;
        private DataGridView dataGridView1;
        public Button btnConsultaGeral;
        private Button btnCrip;
    }
}

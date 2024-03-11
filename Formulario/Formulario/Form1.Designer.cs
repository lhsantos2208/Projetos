﻿namespace Formulario
{
    partial class FormMain
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.btnSegunda = new System.Windows.Forms.Button();
            this.btnSegundaFormThread = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.MenuArquivos = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobreDes = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobreVer = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboMenu = new System.Windows.Forms.ToolStripComboBox();
            this.mPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(13, 60);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(775, 134);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal";
            this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSegunda
            // 
            this.btnSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegunda.Location = new System.Drawing.Point(19, 377);
            this.btnSegunda.Name = "btnSegunda";
            this.btnSegunda.Size = new System.Drawing.Size(201, 61);
            this.btnSegunda.TabIndex = 1;
            this.btnSegunda.Text = "Segunda Form";
            this.btnSegunda.UseVisualStyleBackColor = true;
            this.btnSegunda.Click += new System.EventHandler(this.btnSegunda_Click);
            // 
            // btnSegundaFormThread
            // 
            this.btnSegundaFormThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundaFormThread.Location = new System.Drawing.Point(226, 377);
            this.btnSegundaFormThread.Name = "btnSegundaFormThread";
            this.btnSegundaFormThread.Size = new System.Drawing.Size(201, 61);
            this.btnSegundaFormThread.TabIndex = 2;
            this.btnSegundaFormThread.Text = "Segunda Form Thread";
            this.btnSegundaFormThread.UseVisualStyleBackColor = true;
            this.btnSegundaFormThread.Click += new System.EventHandler(this.btnSegundaFormThread_Click);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuArquivos,
            this.menuAjuda,
            this.ComboMenu,
            this.mPesquisar});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(800, 27);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // MenuArquivos
            // 
            this.MenuArquivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivoNovo,
            this.mArquivoAbrir,
            this.toolStripSeparator1,
            this.mArquivoSair});
            this.MenuArquivos.Name = "MenuArquivos";
            this.MenuArquivos.Size = new System.Drawing.Size(66, 23);
            this.MenuArquivos.Text = "Arquivos";
            // 
            // mArquivoNovo
            // 
            this.mArquivoNovo.Name = "mArquivoNovo";
            this.mArquivoNovo.Size = new System.Drawing.Size(180, 22);
            this.mArquivoNovo.Text = "Novo";
            // 
            // mArquivoAbrir
            // 
            this.mArquivoAbrir.Name = "mArquivoAbrir";
            this.mArquivoAbrir.Size = new System.Drawing.Size(180, 22);
            this.mArquivoAbrir.Text = "Abrir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mArquivoSair
            // 
            this.mArquivoSair.Name = "mArquivoSair";
            this.mArquivoSair.Size = new System.Drawing.Size(180, 22);
            this.mArquivoSair.Text = "Sair";
            // 
            // menuAjuda
            // 
            this.menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjudaSobre});
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(50, 23);
            this.menuAjuda.Text = "Ajuda";
            // 
            // mAjudaSobre
            // 
            this.mAjudaSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjudaSobreDes,
            this.mAjudaSobreVer});
            this.mAjudaSobre.Name = "mAjudaSobre";
            this.mAjudaSobre.Size = new System.Drawing.Size(180, 22);
            this.mAjudaSobre.Text = "Sobre";
            // 
            // mAjudaSobreDes
            // 
            this.mAjudaSobreDes.Name = "mAjudaSobreDes";
            this.mAjudaSobreDes.Size = new System.Drawing.Size(180, 22);
            this.mAjudaSobreDes.Text = "Desenvolvedor";
            // 
            // mAjudaSobreVer
            // 
            this.mAjudaSobreVer.Name = "mAjudaSobreVer";
            this.mAjudaSobreVer.Size = new System.Drawing.Size(180, 22);
            this.mAjudaSobreVer.Text = "Versão";
            // 
            // ComboMenu
            // 
            this.ComboMenu.Items.AddRange(new object[] {
            "Inglês",
            "Português"});
            this.ComboMenu.Name = "ComboMenu";
            this.ComboMenu.Size = new System.Drawing.Size(121, 23);
            // 
            // mPesquisar
            // 
            this.mPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mPesquisar.Name = "mPesquisar";
            this.mPesquisar.Size = new System.Drawing.Size(100, 23);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSegundaFormThread);
            this.Controls.Add(this.btnSegunda);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Button btnSegunda;
        private System.Windows.Forms.Button btnSegundaFormThread;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuArquivos;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNovo;
        private System.Windows.Forms.ToolStripMenuItem mArquivoAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mAjudaSobre;
        private System.Windows.Forms.ToolStripMenuItem mAjudaSobreDes;
        private System.Windows.Forms.ToolStripMenuItem mAjudaSobreVer;
        private System.Windows.Forms.ToolStripComboBox ComboMenu;
        private System.Windows.Forms.ToolStripTextBox mPesquisar;
    }
}


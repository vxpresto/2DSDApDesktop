﻿
namespace ProjetoEstudio
{
    partial class FRMLoginEstudio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnlogar = new System.Windows.Forms.Button();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirAlunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarModalidadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modalidadeToolStripMenuItem,
            this.alunoToolStripMenuItem,
            this.senhaToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // senhaToolStripMenuItem
            // 
            this.senhaToolStripMenuItem.Name = "senhaToolStripMenuItem";
            this.senhaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.senhaToolStripMenuItem.Text = "Sair";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "maria";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "222";
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.btnlogar);
            this.grpLogin.Controls.Add(this.lblsenha);
            this.grpLogin.Controls.Add(this.lbllogin);
            this.grpLogin.Controls.Add(this.textBox1);
            this.grpLogin.Controls.Add(this.textBox2);
            this.grpLogin.Location = new System.Drawing.Point(160, 97);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(463, 258);
            this.grpLogin.TabIndex = 4;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Validação";
            // 
            // btnlogar
            // 
            this.btnlogar.Location = new System.Drawing.Point(151, 176);
            this.btnlogar.Name = "btnlogar";
            this.btnlogar.Size = new System.Drawing.Size(161, 31);
            this.btnlogar.TabIndex = 6;
            this.btnlogar.Text = "Logar";
            this.btnlogar.UseVisualStyleBackColor = true;
            this.btnlogar.Click += new System.EventHandler(this.btnlogar_Click);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(64, 134);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(41, 13);
            this.lblsenha.TabIndex = 5;
            this.lblsenha.Text = "Senha:";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(64, 93);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(36, 13);
            this.lbllogin.TabIndex = 4;
            this.lbllogin.Text = "Login:";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem1,
            this.excluirAlunoToolStripMenuItem1});
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // cadastrarAlunoToolStripMenuItem1
            // 
            this.cadastrarAlunoToolStripMenuItem1.Name = "cadastrarAlunoToolStripMenuItem1";
            this.cadastrarAlunoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cadastrarAlunoToolStripMenuItem1.Text = "Cadastrar Aluno";
            this.cadastrarAlunoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem1_Click);
            // 
            // excluirAlunoToolStripMenuItem1
            // 
            this.excluirAlunoToolStripMenuItem1.Name = "excluirAlunoToolStripMenuItem1";
            this.excluirAlunoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.excluirAlunoToolStripMenuItem1.Text = "Excluir Aluno";
            this.excluirAlunoToolStripMenuItem1.Click += new System.EventHandler(this.excluirAlunoToolStripMenuItem1_Click);
            // 
            // modalidadeToolStripMenuItem
            // 
            this.modalidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarModalidadeToolStripMenuItem1,
            this.excluirModalidadeToolStripMenuItem});
            this.modalidadeToolStripMenuItem.Name = "modalidadeToolStripMenuItem";
            this.modalidadeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.modalidadeToolStripMenuItem.Text = "Modalidade";
            // 
            // cadastrarModalidadeToolStripMenuItem1
            // 
            this.cadastrarModalidadeToolStripMenuItem1.Name = "cadastrarModalidadeToolStripMenuItem1";
            this.cadastrarModalidadeToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.cadastrarModalidadeToolStripMenuItem1.Text = "Cadastrar Modalidade";
            this.cadastrarModalidadeToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarModalidadeToolStripMenuItem1_Click);
            // 
            // excluirModalidadeToolStripMenuItem
            // 
            this.excluirModalidadeToolStripMenuItem.Name = "excluirModalidadeToolStripMenuItem";
            this.excluirModalidadeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.excluirModalidadeToolStripMenuItem.Text = "Excluir Modalidade";
            this.excluirModalidadeToolStripMenuItem.Click += new System.EventHandler(this.excluirModalidadeToolStripMenuItem_Click);
            // 
            // FRMLoginEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMLoginEstudio";
            this.Text = "Estudio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnlogar;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.ToolStripMenuItem senhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarModalidadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirModalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirAlunoToolStripMenuItem1;
    }
}

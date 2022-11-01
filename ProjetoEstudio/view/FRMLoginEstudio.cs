﻿using MySql.Data.MySqlClient;
using ProjetoEstudio.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstudio
{
    public partial class FRMLoginEstudio : Form
    {
        public FRMLoginEstudio()
        {
            InitializeComponent();
            if (DAO_Connection.getConnection("143.106.241.3", "cl201239", "cl201239", "cl*13072005"))
                Console.WriteLine("VOCÊ SE CONECTOU À MATRIX");
            else
                Console.WriteLine("Erro de conexão");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Connection.login(textBox1.Text, textBox2.Text);
            if (tipo == 0)
            {
                MessageBox.Show("Usuário/senha inválidas");
            } else if (tipo == 1){
                MessageBox.Show("Usuário ADM");
                grpLogin.Visible = false;
                menuStrip1.Enabled = true;
            } else if (tipo == 2)
            {
                MessageBox.Show("Usuário restrito");
                grpLogin.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarAlunoToolStripMenuItem1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarModalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMCadastroModalidade cadModalidade = new FRMCadastroModalidade();
            cadModalidade.MdiParent = this;
            cadModalidade.WindowState = FormWindowState.Maximized;
            cadModalidade.Show();
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMExcluirModalidade excluirModalidade = new FRMExcluirModalidade();
            excluirModalidade.MdiParent = this;
            excluirModalidade.WindowState = FormWindowState.Maximized;
            excluirModalidade.Show();
        }

        private void cadastrarAlunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMCadastroAluno cadAluno = new FRMCadastroAluno();
            cadAluno.MdiParent = this;
            cadAluno.WindowState = FormWindowState.Maximized;
            cadAluno.Show();
        }

        private void excluirAlunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMExcluirAluno excluirAluno = new FRMExcluirAluno();
            excluirAluno.MdiParent = this;
            excluirAluno.WindowState = FormWindowState.Maximized;
            excluirAluno.Show();
        }
    }
}
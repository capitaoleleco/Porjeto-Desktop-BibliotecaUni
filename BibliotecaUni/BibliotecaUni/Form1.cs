using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaUni
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
          
        }


        private void configuracaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguracao telaConfig = new FormConfiguracao();
            telaConfig.MdiParent = this;
            telaConfig.WindowState = FormWindowState.Maximized;
            telaConfig.Show();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroLivro telaLivro = new FormCadastroLivro();
            telaLivro.MdiParent = this;
            telaLivro.WindowState = FormWindowState.Maximized;
            telaLivro.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroAluno telaAluno = new FormCadastroAluno();
            telaAluno.MdiParent = this;
            telaAluno.WindowState = FormWindowState.Maximized;
            telaAluno.Show();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisar telaPesquisa = new FormPesquisar();
            telaPesquisa.MdiParent = this;
            telaPesquisa.WindowState = FormWindowState.Maximized;
            telaPesquisa.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair do sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int horaAtual = DateTime.Now.Hour;
            string dataHoraTexto = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            if (horaAtual >= 8 && horaAtual < 18)
            {
                lblDataHora.Text = dataHoraTexto + " | AM";
            }
            else
            {
                lblDataHora.Text = dataHoraTexto + " | PM";
            }
        }

        private void emprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmprestimo telaEmprestimo = new FormEmprestimo();
            telaEmprestimo.MdiParent = this;
            telaEmprestimo.WindowState = FormWindowState.Maximized;
            telaEmprestimo.Show();
        }
    }
}
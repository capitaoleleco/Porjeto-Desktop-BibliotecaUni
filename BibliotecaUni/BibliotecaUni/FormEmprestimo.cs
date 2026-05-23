using BibliotecaUni.DAO;
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
    public partial class FormEmprestimo : Form
    {
        public FormEmprestimo()
        {
            InitializeComponent();
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Por favor, insira a matrícula do aluno!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatricula.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIsbn.Text))
            {
                MessageBox.Show("Por favor, insira o ISBN do livro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIsbn.Focus();
                return;
            }

            try
            {
     
                string matricula = txtMatricula.Text;
                string isbn = txtIsbn.Text;

                DateTime dataEmprestimo = dtpEmprestimo.Value;
                DateTime dataDevolucao = dtpDevolucao.Value;

                
                EmprestimoDAO dao = new EmprestimoDAO();
                dao.InserirPelaMatriculaEIsbn(matricula, isbn, dataEmprestimo, dataDevolucao);

                
                MessageBox.Show("Empréstimo registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Erro ao registar o empréstimo. Verifique se a Matrícula e o ISBN estão corretos.\n\nDetalhes: " + ex.Message, "Erro no Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtMatricula.Clear();
            txtIsbn.Clear();
            dtpEmprestimo.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now.AddDays(7);
            txtMatricula.Focus();
        }

        private void FormEmprestimo_Load_1(object sender, EventArgs e)
        {
            dtpEmprestimo.Value = DateTime.Now;


            dtpDevolucao.Value = DateTime.Now.AddDays(7);
        }
    }
}
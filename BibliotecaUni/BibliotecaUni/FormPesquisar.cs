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
    public partial class FormPesquisar : Form
    {
        public FormPesquisar()
        {
            InitializeComponent();
        }

        private void FormPesquisar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string textoBusca = txtPesquisa.Text;

                
                if (rdbAlunos.Checked)
                {
                    
                    AlunoDAO daoAluno = new AlunoDAO();
                    dgvResultados.DataSource = daoAluno.Pesquisar(textoBusca);
                }
                else if (rdbLivros.Checked)
                {
                    
                    LivroDAO daoLivro = new LivroDAO();
                    dgvResultados.DataSource = daoLivro.BuscarPorTitulo(textoBusca);
                }
                else if(rdbTodos.Checked)
                {
                    AlunoDAO daoAluno = new AlunoDAO();
                    dgvResultados.DataSource =  daoAluno.BuscarPorNome(textoBusca);
                }


                    dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a pesquisa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

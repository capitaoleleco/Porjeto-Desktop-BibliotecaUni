using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaUni.DAO; // Necessário para acessar o banco
using BibliotecaUni.Mapeamento; // Necessário para acessar a classe Aluno

namespace BibliotecaUni
{
    public partial class FormCadastroAluno : Form
    {
        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1. Validação
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Os campos Nome e Matrícula são obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Prepara os dados do aluno
                Aluno novoAluno = new Aluno();
                novoAluno.Nome = txtNome.Text;
                novoAluno.Matricula = txtMatricula.Text;
                novoAluno.Email = txtEmail.Text;
                novoAluno.Telefone = txtTelefone.Text;

                // 3. Envia para o banco de dados
                AlunoDAO dao = new AlunoDAO();
                dao.Inserir(novoAluno);

                MessageBox.Show($"Aluno(a) '{txtNome.Text}' cadastrado(a) com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar aluno no banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtMatricula.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {
        }
    }
}
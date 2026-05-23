using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaUni.DAO;
using BibliotecaUni.Mapeamento;

namespace BibliotecaUni
{
    public partial class FormCadastroLivro : Form
    {
        public FormCadastroLivro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtAutor.Text) || string.IsNullOrWhiteSpace(txtAno.Text))
            {
                MessageBox.Show("Os campos Título, Autor e Ano são obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Prepara os dados do livro
                Livro novoLivro = new Livro();
                novoLivro.Titulo = txtTitulo.Text;
                novoLivro.Autor = txtAutor.Text;
                novoLivro.Isbn = txtIsbn.Text;
                novoLivro.AnoPublicacao = int.Parse(txtAno.Text);

                int qtdDigitada = (int)numQuantidade.Value;
                novoLivro.QuantidadeTotal = qtdDigitada;
                novoLivro.QuantidadeDisponivel = qtdDigitada; 

                // 3. Grava no Banco de Dados
                LivroDAO dao = new LivroDAO();
                dao.Inserir(novoLivro);

                // 4. Feedback e limpeza
                MessageBox.Show($"Sucesso! Cadastrados {qtdDigitada} exemplares de '{txtTitulo.Text}'.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite apenas números no campo Ano.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar livro no banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtIsbn.Clear();
            txtAno.Clear();

            // Reseta a quantidade da tela de volta para 1
            numQuantidade.Value = 1;

            txtTitulo.Focus();
        }

        private void FormCadastroLivro_Load(object sender, EventArgs e)
        {
        }
    }
}
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
    public partial class FormConfiguracao : Form
    {
        public FormConfiguracao()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormConfiguracao_Load);
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormConfiguracao_Load(object sender, EventArgs e)
        {
            richTextBoxTermos.Text =
                "TERMOS \n\n" +
                "1. Do Prazo de Empréstimo:\n" +
                "   O prazo padrão para a permanência de qualquer obra com o aluno é de até 7 dias corridos.\n\n" +
                "2. Das Renovações:\n" +
                "   A renovação do livro poderá ser feita por igual período, desde que a obra não esteja reservada por outro estudante.\n\n" +
                "3. Das Penalidades e Atrasos:\n" +
                "   O atraso na devolução implicará na suspensão temporária de novos empréstimos (1 dia de suspensão para cada dia de atraso).\n\n" +
                "4. Do Cuidado com o Acervo:\n" +
                "   O aluno é inteiramente responsável pela integridade física do livro. Rasuras, rasgos ou perda do material obrigarão o aluno a repor um exemplar idêntico.";

            richTextBoxPrivacidade.Text =
                "POLÍTICA DE PRIVACIDADE \n\n" +
                "O sistema BibliotecaUni preza pela segurança dos dados dos seus usuários corporativos e acadêmicos.\n\n" +
                "1. Coleta de Informações:\n" +
                "   Este software armazena em banco de dados local apenas dados estritamente necessários para o controle operacional, sendo eles: Nome Completo, Matrícula Institucional, E-mail e Telefone de contato.\n\n" +
                "2. Finalidade dos Dados:\n" +
                "   Os dados coletados servem exclusivamente para identificar o responsável pelo livro retirado e permitir a emissão de alertas de atraso.\n\n" +
                "3. Compartilhamento:\n" +
                "   Nenhum dado cadastrado neste sistema é compartilhado com terceiros ou enviado para servidores externos de publicidade.\n\n" +
                "4. Direitos do Usuário:\n" +
                "   O aluno poderá solicitar a alteração ou exclusão total do seu registro cadastral a qualquer momento, desde que não possua pendências de livros em seu nome.";
        }
    }
}
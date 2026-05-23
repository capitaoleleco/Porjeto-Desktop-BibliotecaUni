using BibliotecaUni.DAO;
using BibliotecaUni.Mapeamento;
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
    public partial class FormLogin : Form
    {
        public static Usuario UsuarioLogado { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha o usuário e a senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            try
            {
                
                UsuarioDAO dao = new UsuarioDAO();
                Usuario usuarioTemp = dao.Autenticar(txtUsuario.Text, txtSenha.Text);

                
                if (usuarioTemp != null)
                {
                   
                    if (!usuarioTemp.Ativo)
                    {
                        MessageBox.Show("Este usuário está inativo no sistema. Procure o Administrador.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                   
                    UsuarioLogado = usuarioTemp;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    
                    MessageBox.Show("Usuário ou senha incorretos!", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Clear();
                    txtSenha.Focus();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Erro ao conectar: " + ex.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

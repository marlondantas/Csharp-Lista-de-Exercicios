using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Loja.DTO;
using Usuario.BLL;

namespace loja_camada_ui
{
    public partial class cadastro_usuario : Form
    {
        int comando = 0;
        int id_usuario = 0;
        public cadastro_usuario()
        {
            InitializeComponent();
        }
        public void carregarUsuarios() {
            try
            {
                IList<Usuario_DTO> listUsuario_DTO = new List<Usuario_DTO>();
                listUsuario_DTO = new UsuarioBLL().cargaUsuario();

                dgvUsuarios.DataSource = listUsuario_DTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        
        }
        private void cadastro_usuario_Load(object sender, EventArgs e)
        {
            carregarUsuarios();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvUsuarios.CurrentRow.Index;

            txtNome.Text = Convert.ToString(dgvUsuarios["NM_NOME", sel].Value);
            txtLogin.Text = Convert.ToString(dgvUsuarios["DS_LOGIN", sel].Value);
            txtEmail.Text = Convert.ToString(dgvUsuarios["DS_EMAIL", sel].Value);
            txtSenha.Text = Convert.ToString(dgvUsuarios["DS_SENHA", sel].Value);

            if (Convert.ToString(dgvUsuarios["ID_SITUACAO", sel].Value) == "A")
            {
                cboSituacao.Text = "Ativo";
            }
            else {
                cboSituacao.Text = "Inativo";
            }

            switch (Convert.ToString(dgvUsuarios["ID_PERFIL", sel].Value))
            {
                case "1":
                    cboPerfil.Text = "Administrador";
                    break;
                case "2":
                    cboPerfil.Text = "Operador";
                    break;
                case "3":
                    cboPerfil.Text = "Gerencial";
                    break;
                default:
                    break;
            }

            id_usuario = Convert.ToInt32(dgvUsuarios["CD_USUARIO", sel].Value);
        }
        void limparCampos() {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";

            cboPerfil.Text = "";
            cboSituacao.Text = "";
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            comando = 1;
            limparCampos();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
                Usuario_DTO USU = new Usuario_DTO();

                USU.cd_usuario = id_usuario;

                USU.nm_nome = txtNome.Text;

                USU.ds_login = txtLogin.Text;
                USU.ds_email = txtEmail.Text;

                USU.ds_senha = txtSenha.Text;

                USU.id_situacao = "I";
                if (cboSituacao.Text == "Ativo")
                {
                    USU.id_situacao = "A";
                }

                switch (cboPerfil.Text)
                {
                    case "Administrador":
                        USU.id_perfil = 1;
                        break;
                    case "Operador":
                        USU.id_perfil = 2;
                        break;
                    case "Gerencial":
                        USU.id_perfil = 3;
                        break;
                    default:
                        break;
                }

            if (comando == 1) {
                try
                {
                    int x = new UsuarioBLL().insereUsuario(USU);
                    if (x > 0) {
                        MessageBox.Show("Gravado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro bro:" + ex);
                }
            }
            else if (comando == 2) {
                try
                {
                    int x = new UsuarioBLL().editarUsuario(USU);
                    if (x > 0)
                    {
                        MessageBox.Show("Editado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (comando == 3) {
                try
                {
                    int x = new UsuarioBLL().deletarUsuario(USU);
                    if (x > 0)
                    {
                        MessageBox.Show("Deletado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            
            comando = 0;
            carregarUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            comando = 2;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            comando = 3;
        }
    }
}

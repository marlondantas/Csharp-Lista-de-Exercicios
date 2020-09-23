using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Loja.DTO;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Loja.DAL
{
    public class UsuarioDAL
    {
        public IList<Usuario_DTO> cargaUsuario()
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;

                MySqlCommand CM = new MySqlCommand();

                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM TBOD_USUARIO";
                CM.Connection = con;

                MySqlDataReader MyER;
                IList<Usuario_DTO> listaUsuarioDTO = new List<Usuario_DTO>();

                con.Open();
                MyER = CM.ExecuteReader();

                if (MyER.HasRows)
                {
                    while (MyER.Read()) {
                        Usuario_DTO usu = new Usuario_DTO();

                        //Convertendo os valores
                        usu.cd_usuario = Convert.ToInt32(MyER["CD_USUARIO"]);
                        usu.nm_nome = Convert.ToString(MyER["NM_NOME"]);
                        usu.ds_login = Convert.ToString(MyER["DS_LOGIN"]);
                        usu.ds_email = Convert.ToString(MyER["DS_EMAIL"]);
                        usu.ds_senha = Convert.ToString(MyER["DS_SENHA"]);
                        usu.dt_cadastro = Convert.ToDateTime(MyER["DT_CADASTRO"]);
                        usu.id_situacao = Convert.ToString(MyER["ID_SITUACAO"]);
                        usu.id_perfil = Convert.ToInt32(MyER["ID_PERFIL"]);

                        //Adicionar a lista
                        listaUsuarioDTO.Add(usu);
                    }
                }
                con.Close();
                return listaUsuarioDTO;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int insereUsuario(Usuario_DTO usu) {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;

                MySqlCommand CM = new MySqlCommand();
                CM.CommandType = System.Data.CommandType.Text;

                CM.CommandText = "INSERT INTO TBOD_USUARIO VALUES(" +
                    "(SELECT MAX(tus.CD_USUARIO)+1 FROM TBOD_USUARIO tus)," +
                    "@NM_NOME," +
                    "@DS_LOGIN," +
                    "@DS_EMAIL," +
                    "@DS_SENHA," +
                    "SYSDATE()," +
                    "@ID_SITUACAO," +
                    "@ID_PERFIL" +
                    ")";

                CM.Parameters.Add("NM_NOME", MySqlDbType.VarChar).Value = usu.nm_nome;
                CM.Parameters.Add("DS_LOGIN", MySqlDbType.VarChar).Value = usu.ds_login;
                CM.Parameters.Add("DS_EMAIL", MySqlDbType.VarChar).Value = usu.ds_email;
                CM.Parameters.Add("DS_SENHA", MySqlDbType.VarChar).Value = usu.ds_senha;

                CM.Parameters.Add("ID_SITUACAO", MySqlDbType.VarChar).Value = usu.id_situacao;
                CM.Parameters.Add("ID_PERFIL", MySqlDbType.Int32).Value = usu.id_perfil;

                CM.Connection = con;
                con.Open();
                int qtd = CM.ExecuteNonQuery();
                con.Close();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int editarUsuario(Usuario_DTO usu) {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;

                MySqlCommand CM = new MySqlCommand();
                CM.CommandType = System.Data.CommandType.Text;

                CM.CommandText = 
                    "UPDATE TBOD_USUARIO " +
                    "SET ID_PERFIL = @ID_PERFIL," +
                    "NM_NOME = @NM_NOME," +
                    "DS_LOGIN = @DS_LOGIN," +
                    "DS_EMAIL = @DS_EMAIL," +
                    "DS_SENHA = @DS_SENHA," +
                    "ID_SITUACAO = @ID_SITUACAO " +

                    "WHERE CD_USUARIO=@CD_USUARIO";

                CM.Parameters.Add("ID_PERFIL", MySqlDbType.Int32).Value = usu.id_perfil;
                CM.Parameters.Add("NM_NOME", MySqlDbType.VarChar).Value = usu.nm_nome;
                CM.Parameters.Add("DS_LOGIN", MySqlDbType.VarChar).Value = usu.ds_login;
                CM.Parameters.Add("DS_EMAIL", MySqlDbType.VarChar).Value = usu.ds_email;
                CM.Parameters.Add("DS_SENHA", MySqlDbType.VarChar).Value = usu.ds_senha;
                CM.Parameters.Add("ID_SITUACAO", MySqlDbType.VarChar).Value = usu.id_situacao;

                CM.Parameters.Add("CD_USUARIO", MySqlDbType.Int32).Value = usu.cd_usuario;

                CM.Connection = con;

                con.Open();
                int qtd = CM.ExecuteNonQuery();
                con.Close();

                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deletaUsuario(Usuario_DTO usu) {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;

                MySqlCommand cm = new MySqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM TBOD_USUARIO WHERE CD_USUARIO = @CD_USUARIO";

                cm.Parameters.Add("@CD_USUARIO", MySqlDbType.Int32).Value = usu.cd_usuario;
                cm.Connection = con;
                
                con.Open();
                int qtd = cm.ExecuteNonQuery();
                con.Close();
                
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }

    }
}

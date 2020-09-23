using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Loja.DTO;
using Loja.DAL;

namespace Usuario.BLL
{
    public class UsuarioBLL
    {
        public IList<Usuario_DTO> cargaUsuario()
        {
            try
            {
                return new UsuarioDAL().cargaUsuario();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insereUsuario(Usuario_DTO usu) {

            try
            {
                return new UsuarioDAL().insereUsuario(usu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int editarUsuario(Usuario_DTO usu) {
            try
            {
                return new UsuarioDAL().editarUsuario(usu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deletarUsuario(Usuario_DTO usu) {
            try
            {
                return new UsuarioDAL().deletaUsuario(usu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
  
}

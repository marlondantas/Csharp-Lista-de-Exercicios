using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DTO
{
    public class Usuario_DTO
    {
        public int cd_usuario { get; set; }
        public string nm_nome { get; set; }
        public string ds_login { get; set; }
        public string ds_email { get; set; }
        public string ds_senha { get; set; }
        public DateTime dt_cadastro { get; set; }
        public string id_situacao { get; set; }
        public int id_perfil { get; set; }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTALP_ControleDespesas.Classes
{
    /// <summary>
    /// Método para pegar e também modificar os atributos da classe Usuário 
    /// </summary>
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}

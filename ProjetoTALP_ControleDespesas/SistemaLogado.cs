using ProjetoTALP_ControleDespesas.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoTALP_ControleDespesas
{
    /// <summary>
    /// Método para buscar o nome do usuario logado no sistema.
    /// </summary>
    public class SistemaLogado
    {
        public static Usuario UsuarioLogado { get; set; }
    }
}

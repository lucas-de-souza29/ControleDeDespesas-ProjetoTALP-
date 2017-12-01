using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTALP_ControleDespesas.Classes
{
    /// <summary>
    /// Método para pegar e também poder modificar os atributos da classe Despesas
    /// </summary>
    public class Despesas
    {
        public int IdDespesas { get; set; }
        public string TipoDespesa { get; set; }
        public float Valor { get; set; }
        public string Descricao { get; set; }
    }
}

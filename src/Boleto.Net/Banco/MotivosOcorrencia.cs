using System.Collections.Generic;

namespace BoletoNet
{
    public class MotivosOcorrencia
    {
        public MotivosOcorrencia() {}
        public MotivosOcorrencia(string codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }
}

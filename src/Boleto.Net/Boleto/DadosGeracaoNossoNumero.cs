namespace BoletoNet
{
    public class DadosGeracaoNossoNumero
    {
        public class DadosCedente
        {
            public DadosCedente(string carteira, string convenio, string codigo, ContaBancaria contaBancaria)
            {
                Convenio = convenio;
                Codigo = codigo;
                ContaBancaria = contaBancaria;
                Carteira = carteira;
            }

            public string Convenio { get; set; }
            public string Codigo { get; set; }
            public ContaBancaria ContaBancaria { get; set; }
            public string Carteira { get; set; }
        }
        public long Sequencial { get; private set; }
        public string Carteira { get { return Cedente.Carteira; } }
        public string TipoModalidade { get; set; }
        public DadosCedente Cedente { get; set; }

        internal string NossoNumero { get { return Sequencial.ToString(); } }

        public DadosGeracaoNossoNumero(long sequencial, DadosCedente cedente, string tipoModalidade = "01")
        {
            Sequencial = sequencial;
            Cedente = cedente;
            TipoModalidade = tipoModalidade;
        }
    }
}

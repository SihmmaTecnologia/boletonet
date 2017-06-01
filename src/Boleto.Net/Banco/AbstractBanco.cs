using System;
using System.Threading;
using BoletoNet.Util;
using BoletoNet.Enums;
using System.Collections.Generic;

namespace BoletoNet
{
    public abstract class AbstractBanco
    {

        #region Variaveis

        private int _codigo = 0;
        private string _digito = "0";
        private string _nome = string.Empty;
        private Cedente _cedente = null;

        #endregion Variaveis

        #region Propriedades

        /// <summary>
        /// Código do Banco
        /// 237 - Bradesco; 341 - Itaú
        /// </summary>
        public virtual int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        /// <summary>
        /// Dígito do Banco
        /// </summary>
        public virtual string Digito
        {
            get { return _digito; }
            protected set { _digito = value; }
        }

        /// <summary>
        /// Nome da Instituição Financeira
        /// </summary>
        public virtual string Nome
        {
            get { return _nome; }
            protected set { _nome = value; }
        }

        /// <summary>
        /// Cedente
        /// </summary>
        public virtual Cedente Cedente
        {
            get { return _cedente; }
            protected set { _cedente = value; }
        }

        /// <summary>
        /// Permitir a comunicação entre bancos comerciais estaduais agindo como chave comum na troca de informações entre eles
        /// </summary>
        public string ChaveASBACE { get; set; }
        #endregion Propriedades

        # region Métodos

        /// <summary>
        /// Retorna o campo que compos o código de barras que para todos os bancos são iguais foramado por:
        /// </summary>
        /// <returns></returns>
        public virtual string CampoFixo()
        {
            throw new NotImplementedException("Função não implementada");
        }

        public virtual bool ValidarRemessa(TipoArquivo tipoArquivo, string numeroConvenio, IBanco banco, Cedente cedente, Boletos boletos, int numeroArquivoRemessa, out string mensagem)
        {
            throw new NotImplementedException("Função não implementada na classe filha. Implemente na classe que está sendo criada.");
        }

        /// <summary>
        /// Gera os registros de header do aquivo de remessa
        /// </summary>
        public virtual string GerarHeaderRemessa(string numeroConvenio, Cedente cedente, TipoArquivo tipoArquivo, int numeroArquivoRemessa)
        {
            string _header = "";
            return _header;
        }
        public virtual string GerarHeaderRemessa(string numeroConvenio, Cedente cedente, TipoArquivo tipoArquivo, int numeroArquivoRemessa, Boleto boletos)
        {
            string _header = "";
            return _header;
        }
        /// <summary>
        /// Gera registros de detalhe do arquivo remessa
        /// </summary>
        public virtual string GerarDetalheRemessa(Boleto boleto, int numeroRegistro, TipoArquivo tipoArquivo)
        {
            string _remessa = "";
            return _remessa;
        }
        /// <summary>
        /// Gera registros de Mensagem Variavel do arquivo remessa
        /// </summary>
        public virtual string GerarMensagemVariavelRemessa(Boleto boleto, ref int numeroRegistro, TipoArquivo tipoArquivo)
        {
            string _remessa = "";
            return _remessa;
        }
        /// <summary>
        /// Gera os registros de Trailer do arquivo de remessa
        /// </summary>
        public virtual string GerarTrailerRemessa(int numeroRegistro, TipoArquivo tipoArquivo, Cedente cedente, decimal vltitulostotal)
        {
            string _trailer = "";
            return _trailer;
        }

        /// <summary>
        /// Gera os registros de Trailer do arquivo de remessa com total de registros detalhe
        /// </summary>
        public virtual string GerarTrailerRemessaComDetalhes(int numeroRegistro, int numeroRegistroDetalhes, TipoArquivo tipoArquivo, Cedente cedente, decimal vltitulostotal)
        {
            string _trailer = "";
            return _trailer;
        }



        /// <summary>
        /// Gera os registros de header de aquivo do arquivo de remessa
        /// </summary>
        public virtual string GerarHeaderRemessa(Cedente cedente, TipoArquivo tipoArquivo, int numeroArquivoRemessa)
        {
            string _headerArquivo = "";
            return _headerArquivo;
        }
        /// <summary>
        /// Gera os registros de header de lote do arquivo de remessa
        /// </summary>
        public virtual string GerarHeaderLoteRemessa(string numeroConvenio, Cedente cedente, int numeroArquivoRemessa)
        {
            string _headerLote = "";
            return _headerLote;
        }
        /// <summary>
        /// Gera os registros de header de lote do arquivo de remessa
        /// </summary>
        public virtual string GerarHeaderLoteRemessa(string numeroConvenio, Cedente cedente, int numeroArquivoRemessa, TipoArquivo tipoArquivo)
        {
            string _headerLote = "";
            return _headerLote;
        }
        /// <summary>
        /// Gera os registros de header de lote do arquivo de remessa
        /// </summary>
        public virtual string GerarHeaderLoteRemessa(string numeroConvenio, Cedente cedente, int numeroArquivoRemessa, TipoArquivo tipoArquivo, Boleto boletos)
        {
            string _headerLote = "";
            return _headerLote;
        }

        /// <summary>
        /// Gera registros de detalhe do arquivo remessa - SEGMENTO A
        /// </summary>
        public virtual string GerarDetalheSegmentoARemessa(Boleto boleto, int numeroRegistro)
        {
            string _segmentoP = "";
            return _segmentoP;
        }
        /// <summary>
        /// Gera registros de detalhe do arquivo remessa - SEGMENTO B
        /// </summary>
        public virtual string GerarDetalheSegmentoBRemessa(Boleto boleto, int numeroRegistro)
        {
            string _segmentoP = "";
            return _segmentoP;
        }

        /// <summary>
        /// Gera registros de detalhe do arquivo remessa - SEGMENTO P
        /// </summary>
        public virtual string GerarDetalheSegmentoPRemessa(Boleto boleto, int numeroRegistro, string numeroConvenio, Cedente cedente)
        {
            string _segmentoP = "";
            return _segmentoP;
        }
        public virtual string GerarDetalheSegmentoPRemessa(Boleto boleto, int numeroRegistro, string numeroConvenio, Cedente cedente, Boleto boletos)
        {
            string _segmentoP = "";
            return _segmentoP;
        }
        /// <summary>
        /// Gera registros de detalhe do arquivo remessa - SEGMENTO P
        /// </summary>
        public virtual string GerarDetalheSegmentoPRemessa(Boleto boleto, int numeroRegistro, string numeroConvenio)
        {
            string _segmentoP = "";
            return _segmentoP;
        }
        /// <summary>
        /// Gera registros de detalhe do arquivo remessa - SEGMENTO Q
        /// </summary>
        public virtual string GerarDetalheSegmentoQRemessa(Boleto boleto, int numeroRegistro, TipoArquivo tipoArquivo, Cedente cedente)
        {
            string _segmentoQ = "";
            return _segmentoQ;
        }
        /// <summary>
        /// Gera registros de detalhe do arquivo remessa - SEGMENTO Q
        /// </summary>
        public virtual string GerarDetalheSegmentoQRemessa(Boleto boleto, int numeroRegistro, Sacado sacado)
        {
            string _segmentoQ = "";
            return _segmentoQ;
        }
        /// <summary>
        /// Gera registros de detalhe do arquivo remessa - SEGMENTO Q
        /// </summary>
        public virtual string GerarDetalheSegmentoQRemessa(Boleto boleto, int numeroRegistro, TipoArquivo tipoArquivo)
        {
            string _segmentoQ = "";
            return _segmentoQ;
        }
        /// <summary>
        /// Gera registros de detalhe do arquivo remessa - SEGMENTO R
        /// </summary>
        public virtual string GerarDetalheSegmentoRRemessa(Boleto boleto, int numeroRegistro, TipoArquivo tipoArquivo)
        {
            string _segmentoR = "";
            return _segmentoR;
        }
        /// <summary>
        /// Gera registros de detalhe do arquivo remessa - SEGMENTO S
        /// </summary>
        public virtual string GerarDetalheSegmentoSRemessa(Boleto boleto, int numeroRegistro, TipoArquivo tipoArquivo)
        {
            string _segmentoS = "";
            return _segmentoS;
        }
        /// <summary>
        /// Gera os registros de Trailer de arquivo do arquivo de remessa
        /// </summary>
        public virtual string GerarTrailerArquivoRemessa(int numeroRegistro)
        {
            string _trailerArquivo = "";
            return _trailerArquivo;
        }
        public virtual string GerarTrailerArquivoRemessa(int numeroRegistro, Boleto boletos)
        {
            string _trailerArquivo = "";
            return _trailerArquivo;
        }
        /// <summary>
        /// Gera os registros de Trailer de lote do arquivo de remessa
        /// </summary>
        public virtual string GerarTrailerLoteRemessa(int numeroRegistro)
        {
            string _trailerLote = "";
            return _trailerLote;
        }
        /// <summary>
        /// Gera os registros de Trailer de lote do arquivo de remessa
        /// </summary>
        public virtual string GerarTrailerLoteRemessa(int numeroRegistro, Boleto boletos)
        {
            string _trailerLote = "";
            return _trailerLote;
        }
        /// <summary>
        /// Formata código de barras
        /// </summary>      
        public virtual void FormataCodigoBarra(Boleto boleto)
        {
            throw new NotImplementedException("Função não implementada na classe filha. Implemente na classe que está sendo criada.");
        }
        /// <summary>
        /// Formata linha digitável
        /// </summary>
        public virtual void FormataLinhaDigitavel(Boleto boleto)
        {
            throw new NotImplementedException("Função não implementada na classe filha. Implemente na classe que está sendo criada.");
        }
        /// <summary>
        /// Formata nosso número
        /// </summary>
        public string FormatarNossoNumero(Boleto boleto)
        {
            throw new NotImplementedException("Função não implementada na classe filha. Implemente na classe que está sendo criada.");
        }
        /// <summary>
        /// Formata número do documento
        /// </summary>
        public virtual void FormataNumeroDocumento(Boleto boleto)
        {
            throw new NotImplementedException("Função não implementada na classe filha. Implemente na classe que está sendo criada.");
        }
        /// <summary>
        /// Valida o boleto
        /// </summary>
        public virtual void ValidaBoleto(Boleto boleto)
        {
            throw new NotImplementedException("Função não implementada na classe filha. Implemente na classe que está sendo criada.");
        }

        public virtual DetalheSegmentoWRetornoCNAB240 LerDetalheSegmentoWRetornoCNAB240(string registro)
        {
            var detalhe = new DetalheSegmentoWRetornoCNAB240();

            detalhe.LerDetalheSegmentoWRetornoCNAB240(registro);

            return detalhe;
        }

        public virtual DetalheSegmentoTRetornoCNAB240 LerDetalheSegmentoTRetornoCNAB240(string registro)
        {
            var detalhe = new DetalheSegmentoTRetornoCNAB240(registro);

            detalhe.LerDetalheSegmentoTRetornoCNAB240(registro);

            return detalhe;
        }

        public virtual DetalheSegmentoURetornoCNAB240 LerDetalheSegmentoURetornoCNAB240(string registro)
        {
            var detalhe = new DetalheSegmentoURetornoCNAB240(registro);

            detalhe.LerDetalheSegmentoURetornoCNAB240(registro);

            return detalhe;
        }

        public virtual DetalheSegmentoYRetornoCNAB240 LerDetalheSegmentoYRetornoCNAB240(string registro)
        {
            var detalhe = new DetalheSegmentoYRetornoCNAB240(registro);

            detalhe.LerDetalheSegmentoYRetornoCNAB240(registro);

            return detalhe;
        }

        public virtual DetalheRetorno LerDetalheRetornoCNAB400(string registro)
        {
            try
            {
                int dataOcorrencia = Utils.ToInt32(registro.Substring(110, 6));
                int dataVencimento = Utils.ToInt32(registro.Substring(146, 6));
                int dataCredito = Utils.ToInt32(registro.Substring(295, 6));

                DetalheRetorno detalhe = new DetalheRetorno(registro);

                detalhe.CodigoInscricao = Utils.ToInt32(registro.Substring(1, 2));
                detalhe.NumeroInscricao = registro.Substring(3, 14);
                detalhe.Agencia = Utils.ToInt32(registro.Substring(17, 4));
                detalhe.Conta = Utils.ToInt32(registro.Substring(23, 5));
                detalhe.DACConta = Utils.ToInt32(registro.Substring(28, 1));
                detalhe.UsoEmpresa = registro.Substring(37, 25);
                //
                detalhe.NossoNumeroComDV = registro.Substring(85, 9);
                detalhe.NossoNumero = registro.Substring(85, 8); //Sem o DV
                detalhe.DACNossoNumero = registro.Substring(93, 1); //DV
                //
                detalhe.Carteira = registro.Substring(107, 1);
                detalhe.CodigoOcorrencia = Utils.ToInt32(registro.Substring(108, 2));
                detalhe.DataOcorrencia = Utils.ToDateTime(dataOcorrencia.ToString("##-##-##"));
                detalhe.NumeroDocumento = registro.Substring(116, 10);
                detalhe.NossoNumero = registro.Substring(126, 9);
                detalhe.DataVencimento = Utils.ToDateTime(dataVencimento.ToString("##-##-##"));
                decimal valorTitulo = Convert.ToInt64(registro.Substring(152, 13));
                detalhe.ValorTitulo = valorTitulo / 100;
                detalhe.CodigoBanco = Utils.ToInt32(registro.Substring(165, 3));
                detalhe.AgenciaCobradora = Utils.ToInt32(registro.Substring(168, 4));
                detalhe.Especie = Utils.ToInt32(registro.Substring(173, 2));
                decimal tarifaCobranca = Convert.ToUInt64(registro.Substring(175, 13));
                detalhe.TarifaCobranca = tarifaCobranca / 100;
                // 26 brancos
                decimal iof = Convert.ToUInt64(registro.Substring(214, 13));
                detalhe.IOF = iof / 100;
                decimal valorAbatimento = Convert.ToUInt64(registro.Substring(227, 13));
                detalhe.ValorAbatimento = valorAbatimento / 100;
                decimal valorPrincipal = Convert.ToUInt64(registro.Substring(253, 13));
                detalhe.ValorPrincipal = valorPrincipal / 100;
                decimal jurosMora = Convert.ToUInt64(registro.Substring(266, 13));
                detalhe.JurosMora = jurosMora / 100;
                detalhe.DataOcorrencia = Utils.ToDateTime(dataOcorrencia.ToString("##-##-##"));
                // 293 - 3 brancos
                detalhe.DataCredito = Utils.ToDateTime(dataCredito.ToString("##-##-##"));
                detalhe.InstrucaoCancelada = Utils.ToInt32(registro.Substring(301, 4));
                // 306 - 6 brancos
                // 311 - 13 zeros
                detalhe.NomeSacado = registro.Substring(324, 30);
                // 354 - 23 brancos
                detalhe.Erros = registro.Substring(377, 8);
                // 377 - Registros rejeitados ou alegação do sacado
                // 386 - 7 brancos

                detalhe.CodigoLiquidacao = registro.Substring(392, 2);
                detalhe.NumeroSequencial = Utils.ToInt32(registro.Substring(394, 6));

                return detalhe;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao ler detalhe do arquivo de RETORNO / CNAB 400.", ex);
            }
        }

        public virtual HeaderRetorno LerHeaderRetornoCNAB400(string registro)
        {
            try
            {
                HeaderRetorno header = new HeaderRetorno(registro);
                header.TipoRegistro = Utils.ToInt32(registro.Substring(000, 1));
                header.CodigoRetorno = Utils.ToInt32(registro.Substring(001, 1));
                header.LiteralRetorno = registro.Substring(002, 7);
                header.CodigoServico = Utils.ToInt32(registro.Substring(009, 2));
                header.LiteralServico = registro.Substring(011, 15);
                header.Agencia = Utils.ToInt32(registro.Substring(026, 4));
                header.ComplementoRegistro1 = Utils.ToInt32(registro.Substring(030, 2));
                header.Conta = Utils.ToInt32(registro.Substring(032, 5));
                header.DACConta = Utils.ToInt32(registro.Substring(037, 1));
                header.ComplementoRegistro2 = registro.Substring(038, 8);
                header.NomeEmpresa = registro.Substring(046, 30);
                header.CodigoBanco = Utils.ToInt32(registro.Substring(076, 3));
                header.NomeBanco = registro.Substring(079, 15);
                header.DataGeracao = Utils.ToDateTime(Utils.ToInt32(registro.Substring(094, 6)).ToString("##-##-##"));
                header.Densidade = Utils.ToInt32(registro.Substring(100, 5));
                header.UnidadeDensidade = registro.Substring(105, 3);
                header.NumeroSequencialArquivoRetorno = Utils.ToInt32(registro.Substring(108, 5));
                header.DataCredito = Utils.ToDateTime(Utils.ToInt32(registro.Substring(113, 6)).ToString("##-##-##"));
                header.ComplementoRegistro3 = registro.Substring(119, 275);
                header.NumeroSequencial = Utils.ToInt32(registro.Substring(394, 6));

                return header;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao ler header do arquivo de RETORNO / CNAB 400.", ex);
            }
        }

        /// <summary>
        /// Obtem o código de ocorrência formatado, utiliza '01' - 'Entrada de titulos como padrão'
        /// </summary>
        /// <param name="boleto">Boleto</param>
        /// <returns>Código da ocorrência</returns>
        protected string ObterCodigoDaOcorrencia(Boleto boleto)
        {
            return boleto.Remessa != null ? Utils.FormatCode(boleto.Remessa.CodigoOcorrencia, 2) : TipoOcorrenciaRemessa.EntradaDeTitulos.Format();
        }
        # endregion

        /// <summary>
        /// Fator de vencimento do boleto.
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns>Retorno Fator de Vencimento</returns>
        /// <remarks>
        ///     Wellington(wcarvalho@novatela.com.br) 
        ///     Com base na proposta feita pela CENEGESC de acordo com o comunicado FEBRABAN de n° 082/2012 de 14/06/2012 segue regra para implantação.
        ///     No dia 21/02/20025 o fator vencimento chegará em 9999 assim atigindo o tempo de utilização, para contornar esse problema foi definido com uma nova regra
        ///     de utilizaçao criando um range de uso o range funcionara controlando a emissão dos boletos.
        ///     Exemplo:
        ///         Data Atual: 12/03/2014 = 6000
        ///         Para os boletos vencidos, anterior a data atual é de 3000 fatores cerca de =/- 8 anos. Os boletos que forem gerados acima dos 3000 não serão aceitos pelas instituições financeiras.
        ///         Para os boletos a vencer, posterior a data atual é de 5500 fatores cerca de +/- 15 anos. Os boletos que forem gerados acima dos 5500 não serão aceitos pelas instituições financeiras.
        ///     Quando o fator de vencimento atingir 9999 ele retorna para 1000
        ///     Exemplo:
        ///         21/02/2025 = 9999
        ///         22/02/2025 = 1000
        ///         23/02/2025 = 1001
        ///         ...
        ///         05/03/2025 = 1011
        /// </remarks>
        public static long FatorVencimento(Boleto boleto)
        {
            var dateBase = new DateTime(1997, 10, 7, 0, 0, 0);

            //Verifica se a data esta dentro do range utilizavel
            var dataAtual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            long rangeUtilizavel = Utils.DateDiff(DateInterval.Day, dataAtual, boleto.DataVencimento);

            if (rangeUtilizavel > 5500 || rangeUtilizavel < -3000)
                throw new Exception("Data do vencimento fora do range de utilização proposto pela CENEGESC. Comunicado FEBRABAN de n° 082/2012 de 14/06/2012");

            while (boleto.DataVencimento > dateBase.AddDays(9999))
                dateBase = boleto.DataVencimento.AddDays(-(((Utils.DateDiff(DateInterval.Day, dateBase, boleto.DataVencimento) - 9999) - 1) + 1000));

            return Utils.DateDiff(DateInterval.Day, dateBase, boleto.DataVencimento);
        }

        #region Mod
        internal static int Mod10(string seq)
        {
            /* Variáveis
             * -------------
             * d - Dígito
             * s - Soma
             * p - Peso
             * b - Base
             * r - Resto
             */

            int d, s = 0, p = 2, r;

            for (int i = seq.Length; i > 0; i--)
            {
                r = (Convert.ToInt32(seq.Mid(i, 1)) * p);

                if (r > 9)
                    r = (r / 10) + (r % 10);

                s += r;

                if (p == 2)
                    p = 1;
                else
                    p = p + 1;
            }
            d = ((10 - (s % 10)) % 10);
            return d;
        }

        protected static int Mod11(string seq)
        {
            /* Variáveis
             * -------------
             * d - Dígito
             * s - Soma
             * p - Peso
             * b - Base
             * r - Resto
             */

            int d, s = 0, p = 2, b = 9;

            for (int i = 0; i < seq.Length; i++)
            {
                s = s + (Convert.ToInt32(seq[i]) * p);
                if (p < b)
                    p = p + 1;
                else
                    p = 2;
            }

            d = 11 - (s % 11);
            if (d > 9)
                d = 0;
            return d;
        }

        public static int Mod11Peso2a9(string seq)
        {
            /* Variáveis
             * -------------
             * d - Dígito
             * s - Soma
             * p - Peso
             * b - Base
             * r - Resto
             */

            int d, r, s = 0, p = 2, b = 9;
            string n;

            for (int i = seq.Length; i > 0; i--)
            {
                n = seq.Mid(i, 1);

                s = s + (Convert.ToInt32(n) * p);

                if (p < b)
                    p = p + 1;
                else
                    p = 2;
            }

            r = ((s * 10) % 11);

            if (r == 0 || r == 1 || r == 10)
                d = 1;
            else
                d = r;

            return d;

        }

        protected static int Mod11(string seq, int b)
        {
            /* Variáveis
             * -------------
             * d - Dígito
             * s - Soma
             * p - Peso
             * b - Base
             * r - Resto
             */

            int d, s = 0, p = 2;


            for (int i = seq.Length; i > 0; i--)
            {
                s = s + (Convert.ToInt32(seq.Mid(i, 1)) * p);
                if (p == b)
                    p = 2;
                else
                    p = p + 1;
            }

            d = 11 - (s % 11);


            if ((d > 9) || (d == 0) || (d == 1))
                d = 1;

            return d;
        }

        protected static int Mod11Base9(string seq)
        {
            /* Variáveis
             * -------------
             * d - Dígito
             * s - Soma
             * p - Peso
             * b - Base
             * r - Resto
             */

            int d, s = 0, p = 2, b = 9;


            for (int i = seq.Length - 1; i >= 0; i--)
            {
                string aux = Convert.ToString(seq[i]);
                s += (Convert.ToInt32(aux) * p);
                if (p >= b)
                    p = 2;
                else
                    p = p + 1;
            }

            if (s < 11)
            {
                d = 11 - s;
                return d;
            }
            else
            {
                d = 11 - (s % 11);
                if ((d > 9) || (d == 0))
                    d = 0;

                return d;
            }
        }

        public static int Mod11(string seq, int lim, int flag)
        {
            int mult = 0;
            int total = 0;
            int pos = 1;
            //int res = 0;
            int ndig = 0;
            int nresto = 0;
            string num = string.Empty;

            mult = 1 + (seq.Length % (lim - 1));

            if (mult == 1)
                mult = lim;


            while (pos <= seq.Length)
            {
                num = seq.Mid(pos, 1);
                total += Convert.ToInt32(num) * mult;

                mult -= 1;
                if (mult == 1)
                    mult = lim;

                pos += 1;
            }
            nresto = (total % 11);
            if (flag == 1)
                return nresto;
            else
            {
                if (nresto == 0 || nresto == 1 || nresto == 10)
                    ndig = 1;
                else
                    ndig = (11 - nresto);

                return ndig;
            }
        }

        protected static int Mult10Mod11(string seq, int lim, int flag)
        {
            int mult = 0;
            int total = 0;
            int pos = 1;
            int ndig = 0;
            int nresto = 0;
            string num = string.Empty;

            mult = 1 + (seq.Length % (lim - 1));

            if (mult == 1)
                mult = lim;

            while (pos <= seq.Length)
            {
                num = seq.Mid(pos, 1);
                total += Convert.ToInt32(num) * mult;

                mult -= 1;
                if (mult == 1)
                    mult = lim;

                pos += 1;
            }

            nresto = ((total * 10) % 11);

            if (flag == 1)
                return nresto;
            else
            {
                if (nresto == 0 || nresto == 1 || nresto == 10)
                    ndig = 1;
                else
                    ndig = nresto;

                return ndig;
            }
        }

        /// <summary>
        /// Encontra multiplo de 10 igual ou superior a soma e subtrai multiplo da soma devolvendo o resultado
        /// </summary>
        /// <param name="soma"></param>
        /// <returns></returns>
        protected static int Multiplo10(int soma)
        {
            //Variaveis
            int result = 0;
            //Encontrando multiplo de 10
            while (result < soma)
            {
                result = result + 10;
            }
            //Subtraindo
            result = result - soma;
            //Retornando
            return result;
        }
        #endregion Mod

        /// <summary>
        /// Obtém nosso número sem DV e sem código do Convênio.
        /// </summary>
        /// <returns></returns>
        public virtual long ObterNossoNumeroSemConvenioOuDigitoVerificador(long convenio, string nossoNumero)
        {
            throw new NotImplementedException();
        }

        public virtual long GerarNossoNumero(DadosGeracaoNossoNumero dados)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<MotivosOcorrencia> ObterMotivosOcorrencia(int tipoOcorrencia, string motivos)
        {
            for (int i = 0; i < motivos.Length; i += 2)
            {
                var codigo = motivos.Substring(i, 2);
                string descricao;
                if (!string.IsNullOrEmpty(codigo) && motivosOcorrencia.TryGetValue(codigo, out descricao))
                    yield return new MotivosOcorrencia(codigo, descricao);
            }
        }

        public virtual MotivosOcorrencia ObterMotivoOcorrencia(string motivo)
        {
            string descricao;
            if (!string.IsNullOrEmpty(motivo) && motivosOcorrencia.TryGetValue(motivo, out descricao))
                return new MotivosOcorrencia(motivo, descricao);
            return null;
        }

        private static Dictionary<string, string> motivosOcorrencia = new Dictionary<string, string>()
        {
            { "01",  "Código do Banco Inválido"},
            { "02",  "Código do Registro Detalhe Inválido"},
            { "03",  "Código do Segmento Inválido"},
            { "04",  "Código de Movimento Não Permitido para Carteira"},
            { "05",  "Código de Movimento Inválido"},
            { "06",  "Tipo/Número de Inscrição do Cedente Inválidos"},
            { "07",  "Agência/Conta/DV Inválido"},
            { "08",  "Nosso Número Inválido"},
            { "09",  "Nosso Número Duplicado"},
            { "10",  "Carteira Inválida"},
            { "11",  "Forma de Cadastramento do Título Inválido"},
            { "12",  "Tipo de Documento Inválido"},
            { "13",  "Identificação da Emissão do Bloqueto Inválida"},
            { "14",  "Identificação da Distribuição do Bloqueto Inválida"},
            { "15",  "Características da Cobrança Incompatíveis"},
            { "16",  "Data de Vencimento Inválida"},
            { "17",  "Data de Vencimento Anterior a Data de Emissão"},
            { "18",  "Vencimento Fora do Prazo de Operação"},
            { "19",  "Título a Cargo de Bancos Correspondentes com Vencimento Inferior a XX Dias"},
            { "20",  "Valor do Título Inválido"},
            { "21",  "Espécie do Título Inválida"},
            { "22",  "Espécie do Título Não Permitida para a Carteira"},
            { "23",  "Aceite Inválido"},
            { "24",  "Data da Emissão Inválida"},
            { "25",  "Data da Emissão Posterior a Data de Entrada"},
            { "26",  "Código de Juros de Mora Inválido"},
            { "27",  "Valor / Taxa de Juros de Mora Inválido"},
            { "28",  "Código do Desconto Inválido"},
            { "29",  "Valor do Desconto Maior ou Igual ao Valor do Título"},
            { "30",  "Desconto a Conceder Não Confere"},
            { "31",  "Concessão de Desconto - Já Existe Desconto Anterior"},
            { "32",  "Valor do IOF Inválido"},
            { "33",  "Valor do Abatimento Inválido"},
            { "34",  "Valor do Abatimento Maior ou Igual ao Valor do Título"},
            { "35",  "Valor a Conceder Não Confere"},
            { "36",  "Concessão de Abatimento - Já Existe Abatimento Anterior"},
            { "37",  "Código para Protesto Inválido"},
            { "38",  "Prazo para Protesto Inválido"},
            { "39",  "Pedido de Protesto Não Permitido para o Título"},
            { "40",  "Título com Ordem de Protesto Emitida"},
            { "41",  "Pedido de Cancelamento / Sustação para Títulos sem Instrução de Protesto"},
            { "42",  "Código para Baixa / Devolução Inválido"},
            { "43",  "Prazo para Baixa / Devolução Inválido"},
            { "44",  "Código da Moeda Inválido"},
            { "45",  "Nome do Sacado Não Informado"},
            { "46",  "Tipo / Número de Inscrição do Sacado Inválidos"},
            { "47",  "Endereço do Sacado Não Informado"},
            { "48",  "CEP Inválido"},
            { "49",  "CEP Sem Praça de Cobrança(Não Localizado)"},
            { "50",  "CEP Referente a um Banco Correspondente"},
            { "51",  "CEP incompatível com a Unidade da Federação"},
            { "52",  "Unidade da Federação Inválida"},
            { "53",  "Tipo / Número de Inscrição do Sacador / Avalista Inválidos"},
            { "54",  "Sacador / Avalista Não Informado"},
            { "55",  "Nosso número no Banco Correspondente Não Informado"},
            { "56",  "Código do Banco Correspondente Não Informado"},
            { "57",  "Código da Multa Inválido"},
            { "58",  "Data da Multa Inválida"},
            { "59",  "Valor / Percentual da Multa Inválido"},
            { "60",  "Movimento para Título Não Cadastrado"},
            { "61",  "Alteração da Agência Cobradora / DV Inválida"},
            { "62",  "Tipo de Impressão Inválido"},
            { "63",  "Entrada para Título já Cadastrado"},
            { "64",  "Número da Linha Inválido"},
            { "65",  "Código do Banco para Débito Inválido"},
            { "66",  "Agência / Conta / DV para Débito Inválido"},
            { "67",  "Dados para Débito incompatível com a Identificação da Emissão do Bloqueto"},
            { "68",  "Débito Automático Agendado"},
            { "69",  "Débito Não Agendado - Erro nos Dados da Remessa"},
            { "70",  "Débito Não Agendado - Sacado Não Consta do Cadastro de Autorizante"},
            { "71",  "Débito Não Agendado - Cedente Não Autorizado pelo Sacado"},
            { "72",  "Débito Não Agendado - Cedente Não Participa da Modalidade Débito Automático"},
            { "73",  "Débito Não Agendado - Código de Moeda Diferente de Real(R$)"},
            { "74",  "Débito Não Agendado - Data Vencimento Inválida"},
            { "75",  "Débito Não Agendado, Conforme seu Pedido, Título Não Registrado"},
            { "76",  "Débito Não Agendado, Tipo / Num.Inscrição do Debitado,Inválido"},
            { "77",  "Transferência para Desconto Não Permitida para a Carteira do Título"},
            { "78",  "Data Inferior ou Igual ao Vencimento para Débito Automático"},
            { "79",  "Data Juros de Mora Inválido"},
            { "80",  "Data do Desconto Inválida"},
            { "81",  "Tentativas de Débito Esgotadas - Baixado"},
            { "82",  "Tentativas de Débito Esgotadas - Pendente"},
            { "83",  "Limite Excedido"},
            { "84",  "Número Autorização Inexistente"},
            { "85",  "Título com Pagamento Vinculado"},
            { "86",  "Seu Número Inválido"},
            { "87",  "e-mail / SMS enviado"},
            { "88",  "e-mail Lido"},
            { "89",  "e-mail / SMS devolvido - endereço de e-mail ou número do celular incorreto"},
            { "90",  "e-mail devolvido - caixa postal cheia"},
            { "91",  "e-mail / número do celular do sacado não informado"},
            { "92",  "Sacado optante por Bloqueto Eletrônico - e-mail não enviado"},
            { "93",  "Código para emissão de bloqueto não permite envio de e-mail"},
            { "94",  "Código da Carteira inválido para envio e-mail."},
            { "95",  "Contrato não permite o envio de e-mail"},
            { "96",  "Número de contrato inválido"},
            { "97",  "Rejeição da alteração do prazo limite de recebimento"},
            { "98",  "Rejeição de dispensa de prazo limite de recebimento"},
            { "99",  "Rejeição da alteração do número do título dado pelo cedente"},
            { "A1",  "Rejeição da alteração do número controle do participante"},
            { "A2",  "Rejeição da alteração dos dados do sacado"},
            { "A3",  "Rejeição da alteração dos dados do sacador / avalista"},
            { "A4",  "Sacado DDA"},
            { "A5",  "Registro Rejeitado – Título já Liquidado"},
            { "A6",  "Código do Convenente Inválido ou Encerrado"},
            { "A7",  "Título já se encontra na situação Pretendida"},
            { "A8",  "Valor do Abatimento inválido para cancelamento"},
            { "A9",  "Não autoriza pagamento parcial"},
            { "B1",  "Autoriza recebimento parcia"}
        };
    }
}

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
        /// C�digo do Banco
        /// 237 - Bradesco; 341 - Ita�
        /// </summary>
        public virtual int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        /// <summary>
        /// D�gito do Banco
        /// </summary>
        public virtual string Digito
        {
            get { return _digito; }
            protected set { _digito = value; }
        }

        /// <summary>
        /// Nome da Institui��o Financeira
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
        /// Permitir a comunica��o entre bancos comerciais estaduais agindo como chave comum na troca de informa��es entre eles
        /// </summary>
        public string ChaveASBACE { get; set; }
        #endregion Propriedades

        # region M�todos

        /// <summary>
        /// Retorna o campo que compos o c�digo de barras que para todos os bancos s�o iguais foramado por:
        /// </summary>
        /// <returns></returns>
        public virtual string CampoFixo()
        {
            throw new NotImplementedException("Fun��o n�o implementada");
        }

        public virtual bool ValidarRemessa(TipoArquivo tipoArquivo, string numeroConvenio, IBanco banco, Cedente cedente, Boletos boletos, int numeroArquivoRemessa, out string mensagem)
        {
            throw new NotImplementedException("Fun��o n�o implementada na classe filha. Implemente na classe que est� sendo criada.");
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
        /// Formata c�digo de barras
        /// </summary>      
        public virtual void FormataCodigoBarra(Boleto boleto)
        {
            throw new NotImplementedException("Fun��o n�o implementada na classe filha. Implemente na classe que est� sendo criada.");
        }
        /// <summary>
        /// Formata linha digit�vel
        /// </summary>
        public virtual void FormataLinhaDigitavel(Boleto boleto)
        {
            throw new NotImplementedException("Fun��o n�o implementada na classe filha. Implemente na classe que est� sendo criada.");
        }
        /// <summary>
        /// Formata nosso n�mero
        /// </summary>
        public string FormatarNossoNumero(Boleto boleto)
        {
            throw new NotImplementedException("Fun��o n�o implementada na classe filha. Implemente na classe que est� sendo criada.");
        }
        /// <summary>
        /// Formata n�mero do documento
        /// </summary>
        public virtual void FormataNumeroDocumento(Boleto boleto)
        {
            throw new NotImplementedException("Fun��o n�o implementada na classe filha. Implemente na classe que est� sendo criada.");
        }
        /// <summary>
        /// Valida o boleto
        /// </summary>
        public virtual void ValidaBoleto(Boleto boleto)
        {
            throw new NotImplementedException("Fun��o n�o implementada na classe filha. Implemente na classe que est� sendo criada.");
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
                // 377 - Registros rejeitados ou alega��o do sacado
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
        /// Obtem o c�digo de ocorr�ncia formatado, utiliza '01' - 'Entrada de titulos como padr�o'
        /// </summary>
        /// <param name="boleto">Boleto</param>
        /// <returns>C�digo da ocorr�ncia</returns>
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
        ///     Com base na proposta feita pela CENEGESC de acordo com o comunicado FEBRABAN de n� 082/2012 de 14/06/2012 segue regra para implanta��o.
        ///     No dia 21/02/20025 o fator vencimento chegar� em 9999 assim atigindo o tempo de utiliza��o, para contornar esse problema foi definido com uma nova regra
        ///     de utiliza�ao criando um range de uso o range funcionara controlando a emiss�o dos boletos.
        ///     Exemplo:
        ///         Data Atual: 12/03/2014 = 6000
        ///         Para os boletos vencidos, anterior a data atual � de 3000 fatores cerca de =/- 8 anos. Os boletos que forem gerados acima dos 3000 n�o ser�o aceitos pelas institui��es financeiras.
        ///         Para os boletos a vencer, posterior a data atual � de 5500 fatores cerca de +/- 15 anos. Os boletos que forem gerados acima dos 5500 n�o ser�o aceitos pelas institui��es financeiras.
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
                throw new Exception("Data do vencimento fora do range de utiliza��o proposto pela CENEGESC. Comunicado FEBRABAN de n� 082/2012 de 14/06/2012");

            while (boleto.DataVencimento > dateBase.AddDays(9999))
                dateBase = boleto.DataVencimento.AddDays(-(((Utils.DateDiff(DateInterval.Day, dateBase, boleto.DataVencimento) - 9999) - 1) + 1000));

            return Utils.DateDiff(DateInterval.Day, dateBase, boleto.DataVencimento);
        }

        #region Mod
        internal static int Mod10(string seq)
        {
            /* Vari�veis
             * -------------
             * d - D�gito
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
            /* Vari�veis
             * -------------
             * d - D�gito
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
            /* Vari�veis
             * -------------
             * d - D�gito
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
            /* Vari�veis
             * -------------
             * d - D�gito
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
            /* Vari�veis
             * -------------
             * d - D�gito
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
        /// Obt�m nosso n�mero sem DV e sem c�digo do Conv�nio.
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
            { "01",  "C�digo do Banco Inv�lido"},
            { "02",  "C�digo do Registro Detalhe Inv�lido"},
            { "03",  "C�digo do Segmento Inv�lido"},
            { "04",  "C�digo de Movimento N�o Permitido para Carteira"},
            { "05",  "C�digo de Movimento Inv�lido"},
            { "06",  "Tipo/N�mero de Inscri��o do Cedente Inv�lidos"},
            { "07",  "Ag�ncia/Conta/DV Inv�lido"},
            { "08",  "Nosso N�mero Inv�lido"},
            { "09",  "Nosso N�mero Duplicado"},
            { "10",  "Carteira Inv�lida"},
            { "11",  "Forma de Cadastramento do T�tulo Inv�lido"},
            { "12",  "Tipo de Documento Inv�lido"},
            { "13",  "Identifica��o da Emiss�o do Bloqueto Inv�lida"},
            { "14",  "Identifica��o da Distribui��o do Bloqueto Inv�lida"},
            { "15",  "Caracter�sticas da Cobran�a Incompat�veis"},
            { "16",  "Data de Vencimento Inv�lida"},
            { "17",  "Data de Vencimento Anterior a Data de Emiss�o"},
            { "18",  "Vencimento Fora do Prazo de Opera��o"},
            { "19",  "T�tulo a Cargo de Bancos Correspondentes com Vencimento Inferior a XX Dias"},
            { "20",  "Valor do T�tulo Inv�lido"},
            { "21",  "Esp�cie do T�tulo Inv�lida"},
            { "22",  "Esp�cie do T�tulo N�o Permitida para a Carteira"},
            { "23",  "Aceite Inv�lido"},
            { "24",  "Data da Emiss�o Inv�lida"},
            { "25",  "Data da Emiss�o Posterior a Data de Entrada"},
            { "26",  "C�digo de Juros de Mora Inv�lido"},
            { "27",  "Valor / Taxa de Juros de Mora Inv�lido"},
            { "28",  "C�digo do Desconto Inv�lido"},
            { "29",  "Valor do Desconto Maior ou Igual ao Valor do T�tulo"},
            { "30",  "Desconto a Conceder N�o Confere"},
            { "31",  "Concess�o de Desconto - J� Existe Desconto Anterior"},
            { "32",  "Valor do IOF Inv�lido"},
            { "33",  "Valor do Abatimento Inv�lido"},
            { "34",  "Valor do Abatimento Maior ou Igual ao Valor do T�tulo"},
            { "35",  "Valor a Conceder N�o Confere"},
            { "36",  "Concess�o de Abatimento - J� Existe Abatimento Anterior"},
            { "37",  "C�digo para Protesto Inv�lido"},
            { "38",  "Prazo para Protesto Inv�lido"},
            { "39",  "Pedido de Protesto N�o Permitido para o T�tulo"},
            { "40",  "T�tulo com Ordem de Protesto Emitida"},
            { "41",  "Pedido de Cancelamento / Susta��o para T�tulos sem Instru��o de Protesto"},
            { "42",  "C�digo para Baixa / Devolu��o Inv�lido"},
            { "43",  "Prazo para Baixa / Devolu��o Inv�lido"},
            { "44",  "C�digo da Moeda Inv�lido"},
            { "45",  "Nome do Sacado N�o Informado"},
            { "46",  "Tipo / N�mero de Inscri��o do Sacado Inv�lidos"},
            { "47",  "Endere�o do Sacado N�o Informado"},
            { "48",  "CEP Inv�lido"},
            { "49",  "CEP Sem Pra�a de Cobran�a(N�o Localizado)"},
            { "50",  "CEP Referente a um Banco Correspondente"},
            { "51",  "CEP incompat�vel com a Unidade da Federa��o"},
            { "52",  "Unidade da Federa��o Inv�lida"},
            { "53",  "Tipo / N�mero de Inscri��o do Sacador / Avalista Inv�lidos"},
            { "54",  "Sacador / Avalista N�o Informado"},
            { "55",  "Nosso n�mero no Banco Correspondente N�o Informado"},
            { "56",  "C�digo do Banco Correspondente N�o Informado"},
            { "57",  "C�digo da Multa Inv�lido"},
            { "58",  "Data da Multa Inv�lida"},
            { "59",  "Valor / Percentual da Multa Inv�lido"},
            { "60",  "Movimento para T�tulo N�o Cadastrado"},
            { "61",  "Altera��o da Ag�ncia Cobradora / DV Inv�lida"},
            { "62",  "Tipo de Impress�o Inv�lido"},
            { "63",  "Entrada para T�tulo j� Cadastrado"},
            { "64",  "N�mero da Linha Inv�lido"},
            { "65",  "C�digo do Banco para D�bito Inv�lido"},
            { "66",  "Ag�ncia / Conta / DV para D�bito Inv�lido"},
            { "67",  "Dados para D�bito incompat�vel com a Identifica��o da Emiss�o do Bloqueto"},
            { "68",  "D�bito Autom�tico Agendado"},
            { "69",  "D�bito N�o Agendado - Erro nos Dados da Remessa"},
            { "70",  "D�bito N�o Agendado - Sacado N�o Consta do Cadastro de Autorizante"},
            { "71",  "D�bito N�o Agendado - Cedente N�o Autorizado pelo Sacado"},
            { "72",  "D�bito N�o Agendado - Cedente N�o Participa da Modalidade D�bito Autom�tico"},
            { "73",  "D�bito N�o Agendado - C�digo de Moeda Diferente de Real(R$)"},
            { "74",  "D�bito N�o Agendado - Data Vencimento Inv�lida"},
            { "75",  "D�bito N�o Agendado, Conforme seu Pedido, T�tulo N�o Registrado"},
            { "76",  "D�bito N�o Agendado, Tipo / Num.Inscri��o do Debitado,Inv�lido"},
            { "77",  "Transfer�ncia para Desconto N�o Permitida para a Carteira do T�tulo"},
            { "78",  "Data Inferior ou Igual ao Vencimento para D�bito Autom�tico"},
            { "79",  "Data Juros de Mora Inv�lido"},
            { "80",  "Data do Desconto Inv�lida"},
            { "81",  "Tentativas de D�bito Esgotadas - Baixado"},
            { "82",  "Tentativas de D�bito Esgotadas - Pendente"},
            { "83",  "Limite Excedido"},
            { "84",  "N�mero Autoriza��o Inexistente"},
            { "85",  "T�tulo com Pagamento Vinculado"},
            { "86",  "Seu N�mero Inv�lido"},
            { "87",  "e-mail / SMS enviado"},
            { "88",  "e-mail Lido"},
            { "89",  "e-mail / SMS devolvido - endere�o de e-mail ou n�mero do celular incorreto"},
            { "90",  "e-mail devolvido - caixa postal cheia"},
            { "91",  "e-mail / n�mero do celular do sacado n�o informado"},
            { "92",  "Sacado optante por Bloqueto Eletr�nico - e-mail n�o enviado"},
            { "93",  "C�digo para emiss�o de bloqueto n�o permite envio de e-mail"},
            { "94",  "C�digo da Carteira inv�lido para envio e-mail."},
            { "95",  "Contrato n�o permite o envio de e-mail"},
            { "96",  "N�mero de contrato inv�lido"},
            { "97",  "Rejei��o da altera��o do prazo limite de recebimento"},
            { "98",  "Rejei��o de dispensa de prazo limite de recebimento"},
            { "99",  "Rejei��o da altera��o do n�mero do t�tulo dado pelo cedente"},
            { "A1",  "Rejei��o da altera��o do n�mero controle do participante"},
            { "A2",  "Rejei��o da altera��o dos dados do sacado"},
            { "A3",  "Rejei��o da altera��o dos dados do sacador / avalista"},
            { "A4",  "Sacado DDA"},
            { "A5",  "Registro Rejeitado � T�tulo j� Liquidado"},
            { "A6",  "C�digo do Convenente Inv�lido ou Encerrado"},
            { "A7",  "T�tulo j� se encontra na situa��o Pretendida"},
            { "A8",  "Valor do Abatimento inv�lido para cancelamento"},
            { "A9",  "N�o autoriza pagamento parcial"},
            { "B1",  "Autoriza recebimento parcia"}
        };
    }
}

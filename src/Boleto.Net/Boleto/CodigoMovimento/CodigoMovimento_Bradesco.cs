using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoletoNet
{
    public enum EnumCodigoMovimento_BancoBradesco
    {
        EntradaConfirmada = 02,
        EntradaRejeitada = 03,
        LiquidacaoNormal = 06,
        BaixadoAutomatViaArquivo = 09,
        BaixadoConformeInstrucoesDaAgencia = 10,
        EmSerArquivodeTitulosPendentes = 11,
        AbatimentoConcedido = 12,
        AbatimentoCancelado = 13,
        VencimentoAlterado = 14,
        LiquidacaoEmCartorio = 15,
        TituloPagoEmChequeVinculado = 16,
        LiquidacaoAposBaixaOuTituloNaoRegistrado = 17,
        AcertoDeDepositaria = 18,
        ConfirmacaoRecebInstDeProtesto = 19,
        ConfirmacaoRecebimentoInstrucaoSustacaoDeProtesto = 20,
        AcertodoControleDoParticipante = 21,
        TituloComPagamentoCancelado = 22,
        EntradadoTituloEmCartorio = 23,
        EntradaRejeitadaPorCEPIrregular = 24,
        ConfirmacaoRecebInstdeProtestoFalimentar = 25,
        BaixaRejeitada = 27,
        DebitoDeTarifasCustas = 28,
        OcorrenciasDoPagador = 29,
        AlteracaodeOutrosDadosRejeitados = 30,
        InstrucaoRejeitada = 32,
        ConfirmacaoPedidoAlteracaoOutrosDados = 33,
        RetiradodeCartorioEManutencaoCarteira = 34,
        DesagendamentoDoDebitoAutomatico = 35,
        EstornoDePagamento = 40,
        SustadoJudicial = 55,
        AcertodosDadosDoRateiodeCredito = 68,
        CancelamentoDosDadosDoRateio = 69,
        ConfirmacaoRecebPedidodeNegativacao = 073,
        ConfirPedidodeExcldeNegat = 074
    }

    public class CodigoMovimento_BancoBradesco : AbstractCodigoMovimento, ICodigoMovimento
    {
        public CodigoMovimento_BancoBradesco() { }

        public CodigoMovimento_BancoBradesco(int codigo)
        {
            try
            {
                this.carregar(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }

        private void carregar(int codigo)
        {
            try
            {
                this.Banco = new Banco_Bradesco();

                switch ((EnumCodigoMovimento_BancoBradesco)codigo)
                {
                    case EnumCodigoMovimento_BancoBradesco.EntradaConfirmada:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.EntradaConfirmada;
                        this.Descricao = "Entrada confirmada";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.EntradaRejeitada:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.EntradaRejeitada;
                        this.Descricao = "Entrada rejeitada";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.LiquidacaoNormal:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.LiquidacaoNormal;
                        this.Descricao = "LiquidacaoNormal";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.BaixadoAutomatViaArquivo:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.BaixadoAutomatViaArquivo;
                        this.Descricao = "Baixado Automaticamento Via Arquivo";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.BaixadoConformeInstrucoesDaAgencia:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.BaixadoConformeInstrucoesDaAgencia;
                        this.Descricao = "Baixado conforme instruções da agência";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.EmSerArquivodeTitulosPendentes:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.EmSerArquivodeTitulosPendentes;
                        this.Descricao = "Arquivo de titulos pendentes";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.AbatimentoConcedido:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.AbatimentoConcedido;
                        this.Descricao = "Abatimento concedido";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.AbatimentoCancelado:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.AbatimentoCancelado;
                        this.Descricao = "Abatimento cancelado";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.VencimentoAlterado:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.VencimentoAlterado;
                        this.Descricao = "Vencimento alterado";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.LiquidacaoEmCartorio:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.LiquidacaoEmCartorio;
                        this.Descricao = "Liquidação em cartório";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.TituloPagoEmChequeVinculado:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.TituloPagoEmChequeVinculado;
                        this.Descricao = "Titulo pago em cheque vinculado";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.LiquidacaoAposBaixaOuTituloNaoRegistrado:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.LiquidacaoAposBaixaOuTituloNaoRegistrado;
                        this.Descricao = "Liquidação após baixa ou título não registrado";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.AcertoDeDepositaria:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.AcertoDeDepositaria;
                        this.Descricao = "Acerto de depositária";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.ConfirmacaoRecebimentoInstrucaoSustacaoDeProtesto:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.ConfirmacaoRecebimentoInstrucaoSustacaoDeProtesto;
                        this.Descricao = "Confirmação de recebimento de instrução de sustação de protesto";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.ConfirmacaoRecebInstDeProtesto:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.ConfirmacaoRecebInstDeProtesto;
                        this.Descricao = "Confirmação de recebimento de instrução de protesto";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.AcertodoControleDoParticipante:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.AcertodoControleDoParticipante;
                        this.Descricao = "Acerto de controle do participante";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.TituloComPagamentoCancelado:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.TituloComPagamentoCancelado;
                        this.Descricao = "Título com pagamento cancelado";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.EntradadoTituloEmCartorio:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.EntradadoTituloEmCartorio;
                        this.Descricao = "Entrada título em cartório";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.EntradaRejeitadaPorCEPIrregular:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.EntradaRejeitadaPorCEPIrregular;
                        this.Descricao = "Entrada rejeitada por CEP irregular";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.ConfirmacaoRecebInstdeProtestoFalimentar:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.ConfirmacaoRecebInstdeProtestoFalimentar;
                        this.Descricao = "Confirmação recebimento instrução de protesto falimentar";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.BaixaRejeitada:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.BaixaRejeitada;
                        this.Descricao = "Baixa rejeitada";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.DebitoDeTarifasCustas:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.DebitoDeTarifasCustas;
                        this.Descricao = "Débito de tarifas custas";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.OcorrenciasDoPagador:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.OcorrenciasDoPagador;
                        this.Descricao = "Ocorrências do pagador";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.AlteracaodeOutrosDadosRejeitados:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.AlteracaodeOutrosDadosRejeitados;
                        this.Descricao = "Alteração de outros dados rejeitados";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.InstrucaoRejeitada:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.InstrucaoRejeitada;
                        this.Descricao = "Instrução rejeitada";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.ConfirmacaoPedidoAlteracaoOutrosDados:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.ConfirmacaoPedidoAlteracaoOutrosDados;
                        this.Descricao = "Confirmarção pedido alteração outros dados";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.RetiradodeCartorioEManutencaoCarteira:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.RetiradodeCartorioEManutencaoCarteira;
                        this.Descricao = "Cartório e manutenção carteira";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.DesagendamentoDoDebitoAutomatico:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.DesagendamentoDoDebitoAutomatico;
                        this.Descricao = "Desagendamento do débito automático";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.EstornoDePagamento:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.EstornoDePagamento;
                        this.Descricao = "Estorno de pagamento";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.SustadoJudicial:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.SustadoJudicial;
                        this.Descricao = "Sustado Judicial";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.AcertodosDadosDoRateiodeCredito:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.AcertodosDadosDoRateiodeCredito;
                        this.Descricao = "Acerto dos dados do rateio de crédito";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.CancelamentoDosDadosDoRateio:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.CancelamentoDosDadosDoRateio;
                        this.Descricao = "Cancelamento dos dados do rateio";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.ConfirmacaoRecebPedidodeNegativacao:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.ConfirmacaoRecebPedidodeNegativacao;
                        this.Descricao = "Confirmação recebimento pedido de negativação";
                        break;
                    case EnumCodigoMovimento_BancoBradesco.ConfirPedidodeExcldeNegat:
                        this.Codigo = (int)EnumCodigoMovimento_BancoBradesco.ConfirPedidodeExcldeNegat;
                        this.Descricao = "Confirmação pedido excludente negativo";
                        break;
                    default:
                        this.Codigo = 0;
                        this.Descricao = "( Selecione )";
                        break;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }

        public override TipoOcorrenciaRetorno ObterCorrespondenteFebraban()
        {
            return ObterCorrespondenteFebraban(correspondentesFebraban, (EnumCodigoMovimento_BancoBradesco)Codigo);
        }

        private Dictionary<EnumCodigoMovimento_BancoBradesco, TipoOcorrenciaRetorno> correspondentesFebraban = new Dictionary<EnumCodigoMovimento_BancoBradesco, TipoOcorrenciaRetorno>()
        {
            { EnumCodigoMovimento_BancoBradesco.EntradaConfirmada, TipoOcorrenciaRetorno.EntradaConfirmada },
            { EnumCodigoMovimento_BancoBradesco.EntradaRejeitada, TipoOcorrenciaRetorno.EntradaRejeitada },
            { EnumCodigoMovimento_BancoBradesco.LiquidacaoNormal, TipoOcorrenciaRetorno.Liquidacao },
            { EnumCodigoMovimento_BancoBradesco.BaixadoAutomatViaArquivo, TipoOcorrenciaRetorno.Baixa },
            { EnumCodigoMovimento_BancoBradesco.EmSerArquivodeTitulosPendentes, TipoOcorrenciaRetorno.TitulosEmCarteira },
            { EnumCodigoMovimento_BancoBradesco.AbatimentoConcedido, TipoOcorrenciaRetorno.ConfirmacaoRecebimentoInstrucaoDeAbatimento },
            { EnumCodigoMovimento_BancoBradesco.AbatimentoCancelado, TipoOcorrenciaRetorno.ConfirmacaoRecebimentoInstrucaoDeCancelamentoAbatimento },
            { EnumCodigoMovimento_BancoBradesco.VencimentoAlterado, TipoOcorrenciaRetorno.ConfirmacaoRecebimentoInstrucaoAlteracaoDeVencimento },
            { EnumCodigoMovimento_BancoBradesco.LiquidacaoEmCartorio, TipoOcorrenciaRetorno.FrancoDePagamento },
            { EnumCodigoMovimento_BancoBradesco.LiquidacaoAposBaixaOuTituloNaoRegistrado, TipoOcorrenciaRetorno.LiquidacaoAposBaixaOuLiquidacaoTituloNaoRegistrado },
            { EnumCodigoMovimento_BancoBradesco.ConfirmacaoRecebInstDeProtesto, TipoOcorrenciaRetorno.ConfirmacaoRecebimentoInstrucaoDeProtesto },
            { EnumCodigoMovimento_BancoBradesco.ConfirmacaoRecebimentoInstrucaoSustacaoDeProtesto, TipoOcorrenciaRetorno.ConfirmacaoRecebimentoInstrucaoDeSustacaoCancelamentoDeProtesto },
            { EnumCodigoMovimento_BancoBradesco.EntradadoTituloEmCartorio, TipoOcorrenciaRetorno.RemessaACartorio  },
            { EnumCodigoMovimento_BancoBradesco.RetiradodeCartorioEManutencaoCarteira, TipoOcorrenciaRetorno.RetiradaDeCartorioEManutencaoEmCarteira },
            { EnumCodigoMovimento_BancoBradesco.ConfirmacaoRecebInstdeProtestoFalimentar, TipoOcorrenciaRetorno.ProtestadoEBaixado },
            { EnumCodigoMovimento_BancoBradesco.BaixaRejeitada, TipoOcorrenciaRetorno.BaixaRejeitada },
            { EnumCodigoMovimento_BancoBradesco.InstrucaoRejeitada, TipoOcorrenciaRetorno.InstrucaoRejeitada },
            { EnumCodigoMovimento_BancoBradesco.DebitoDeTarifasCustas, TipoOcorrenciaRetorno.DebitoDeTarifasCustas },
            { EnumCodigoMovimento_BancoBradesco.OcorrenciasDoPagador, TipoOcorrenciaRetorno.OcorrenciasDoPagador },
            { EnumCodigoMovimento_BancoBradesco.AlteracaodeOutrosDadosRejeitados, TipoOcorrenciaRetorno.AlteracaoDeDadosRejeitada },
            { EnumCodigoMovimento_BancoBradesco.AcertodosDadosDoRateiodeCredito, TipoOcorrenciaRetorno.ConfirmacaoDaAlteracaoDosDadosDoRateioDeCredito },
            { EnumCodigoMovimento_BancoBradesco.CancelamentoDosDadosDoRateio, TipoOcorrenciaRetorno.ConfirmacaoDoCancelamentoDosDadosDoRateioDeCredito },
            { EnumCodigoMovimento_BancoBradesco.DesagendamentoDoDebitoAutomatico, TipoOcorrenciaRetorno.ConfirmacaoDoDesagendamentoDoDebitoAutomatico },
            { EnumCodigoMovimento_BancoBradesco.ConfirmacaoPedidoAlteracaoOutrosDados, TipoOcorrenciaRetorno.ConfirmacaoDaAlteracaoDonumeroDoTitulodadoPeloBeneficiário },
            { EnumCodigoMovimento_BancoBradesco.SustadoJudicial, TipoOcorrenciaRetorno.TituloSustadoJudicialmente },
        };
    }
}

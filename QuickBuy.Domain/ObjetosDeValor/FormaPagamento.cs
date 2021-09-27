using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickBuy.Domain.Enumerados;

namespace QuickBuy.Domain.ObjetosDeValor
{
    public class FormaPagamento
    {
        public int Id {  get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhNaoDefinido()
        {
            return (Id == (int)TipoFormaPagamentoEnum.NaoDefinido);
        }

        public bool EhBoleto()
        {
            return (Id == (int)TipoFormaPagamentoEnum.Boleto);
        }

        public bool EhCartaoCredito()
        {
            return (Id == (int)TipoFormaPagamentoEnum.CartaoCredito);
        }

        public bool EhPix()
        {
            return (Id == (int)TipoFormaPagamentoEnum.PIX);
        }

        public bool EhDeposito()
        {
            return (Id == (int)TipoFormaPagamentoEnum.Deposito);
        }





    }
}

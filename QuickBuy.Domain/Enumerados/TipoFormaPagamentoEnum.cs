using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Enumerados
{
    public enum TipoFormaPagamentoEnum
    {
        NaoDefinido = 0,
        Boleto = 1,
        CartaoCredito = 2,
        PIX = 3,
        Deposito = 4
    }
}

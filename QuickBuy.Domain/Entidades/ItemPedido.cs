using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Entidades
{
    public class ItemPedido
    {
        public int Id {  get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}

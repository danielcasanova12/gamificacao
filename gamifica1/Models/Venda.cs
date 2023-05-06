using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamifica.Models
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> ProdutosVendidos { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorTotalCompra { get; set; }
    }
}

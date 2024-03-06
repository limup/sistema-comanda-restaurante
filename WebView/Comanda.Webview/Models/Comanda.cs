using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comanda.Webview.Models
{
    public class Comanda
    {
        public string id { get; set; }

        public int idProduto { get; set; }

        public int qtidadeItem { get; set; }

        public List<Produto> listaProdutos { get; set; }

        public Comanda()
        {
            listaProdutos = new List<Produto>();
        }
    }
}
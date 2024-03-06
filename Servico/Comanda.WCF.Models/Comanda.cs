using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Comanda.WCF.Models
{
    [DataContract]
    public class Comanda
    {
        public string id { get; set; }

        [DataMember(Order = 0)]
        public int idProduto { get; set; }

        [DataMember(Order = 1)]
        public int qtidadeItem { get; set; }

        [DataMember(Order = 2)]
        public List<Produto> listaProdutos { get; set; }

        public Comanda()
        {
            listaProdutos = new List<Produto>();
        }
    }
}
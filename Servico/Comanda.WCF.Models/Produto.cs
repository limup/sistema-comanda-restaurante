using System.Runtime.Serialization;

namespace Comanda.WCF.Models
{
    [DataContract]
    public class Produto
    {
        public int id { get; set; }

        [DataMember(Order = 0)]
        public string descricao { get; set; }

        [DataMember(Order = 1)]
        public double valor { get; set; }

        [DataMember(Order = 2)]
        public int estoque { get; set; }
    }
}
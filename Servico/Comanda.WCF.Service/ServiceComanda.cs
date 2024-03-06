using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comanda.WCF.Models;

namespace Comanda.WCF.Service
{
    public class ServiceComanda : IServiceComanda
    {
        private Business.ComandaController ComandaController = new Business.ComandaController();

        public bool CadastrarComanda(Models.Comanda comanda)
        {
            ComandaController = new Business.ComandaController();
            return ComandaController.CadastrarComanda(comanda);
        }

        public List<Models.Comanda> ListarComandas()
        {
            ComandaController = new Business.ComandaController();
            return ComandaController.ListarComandas();
        }

        public List<Produto> ListarProdutos()
        {
            ComandaController = new Business.ComandaController();
            return ComandaController.ListarProdutos();
        }

        public Models.Comanda ObterComanda(string idComanda)
        {
            ComandaController = new Business.ComandaController();
            return ComandaController.ObterComanda(Convert.ToInt32(idComanda));
        }
    }
}

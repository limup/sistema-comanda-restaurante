using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comanda.WCF.Business
{
    public class ComandaController
    {
        public bool CadastrarComanda(Models.Comanda Comanda)
        {
            try
            {
                using (Data.Data.Comanda DataAccess = new Data.Data.Comanda())
                {
                    return DataAccess.CadastrarComanda(Comanda);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Models.Comanda> ListarComandas()
        {
            List<Models.Comanda> ListaComandas = new List<Models.Comanda>();

            try
            {
                using (Data.Data.Comanda DataAccess = new Data.Data.Comanda())
                {
                    ListaComandas = DataAccess.ListarComandas();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ListaComandas;
        }

        public List<Models.Produto> ListarProdutos()
        {
            throw new NotImplementedException();
        }

        public Models.Comanda ObterComanda(int idComanda)
        {
            try
            {
                using (Data.Data.Comanda DataAccess = new Data.Data.Comanda())
                {
                    return DataAccess.ObterComanda(idComanda);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

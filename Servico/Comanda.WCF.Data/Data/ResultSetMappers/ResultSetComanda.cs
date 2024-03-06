using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comanda.WCF.Models;
using System.Data;

namespace Comanda.WCF.Data.Data.ResultSetMappers
{
    public class ResultSetComanda : IResultSetMapper<Models.Comanda>
    {
        IEnumerable<Models.Comanda> IResultSetMapper<Models.Comanda>.MapSet(IDataReader reader)
        {
            List<Models.Comanda> retorno = new List<Models.Comanda>();

            try
            {
                while (reader.Read())
                {
                    Models.Comanda Comanda = new Models.Comanda();

                    Comanda.id = reader["id"] == DBNull.Value ? string.Empty : reader["id"].ToString();
                    Comanda.idProduto = reader["idProduto"] == DBNull.Value ? 0 : Convert.ToInt32(reader["idProduto"]);
                    Comanda.qtidadeItem = reader["qtidadeItem"] == DBNull.Value ? 0 : Convert.ToInt32(reader["qtidadeItem"]);

                    retorno.Add(Comanda);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                reader.Close();
                System.GC.Collect();
            }

            return retorno;
        }
    }
}

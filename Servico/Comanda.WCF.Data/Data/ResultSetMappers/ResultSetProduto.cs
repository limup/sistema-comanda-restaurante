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
    public class ResultSetProduto : IResultSetMapper<Models.Produto>
    {
        public IEnumerable<Models.Produto> MapSet(IDataReader reader)
        {
            List<Models.Produto> retorno = new List<Models.Produto>();

            try
            {
                while (reader.Read())
                {
                    Models.Produto produto = new Models.Produto();

                    produto.id = reader["id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["id"]);
                    produto.descricao = reader["descricao"] == DBNull.Value ? string.Empty : reader["descricao"].ToString();
                    produto.estoque = reader["id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["estoque"]);
                    produto.valor = reader["id"] == DBNull.Value ? 0 : Convert.ToDouble(reader["valor"]);

                    retorno.Add(produto);
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

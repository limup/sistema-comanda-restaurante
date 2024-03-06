using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comanda.WCF.Data.Data
{
    public class Produto : BaseData
    {
        public List<Models.Produto> ListarProdutos()
        {
            #region Query

            string query = @"SELECT * 
                             FROM [TABLE]
                             WHERE [TABLE].Id = @CodSampleID";

            #endregion

            try
            {
                var accessor = database.CreateSqlStringAccessor<Models.Produto>(query, new ResultSetMappers.ResultSetProduto());
                return accessor.Execute().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Comanda.WCF.Data.Data
{
    public class Comanda : BaseData
    {
        public List<Models.Comanda> ListarComandas()
        {
            #region Query

            string query = @"SELECT * 
                             FROM [TABLE]
                             WHERE [TABLE].Id = @CodSampleID";

            #endregion

            try
            {
                var accessor = database.CreateSqlStringAccessor<Models.Comanda>(query, new ResultSetMappers.ResultSetComanda());
                return accessor.Execute().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Models.Comanda ObterComanda(int idComanda)
        {
            #region Query

            string query = @"SELECT * 
                             FROM [TABLE]
                             WHERE [TABLE].Id = @CodSampleID";

            #endregion

            try
            {
                var accessor = database.CreateSqlStringAccessor<Models.Comanda>(query, new ParameterMappers.ParameterMapperComanda(),
                                                                                        new ResultSetMappers.ResultSetComanda());
                return accessor.Execute().ToList().First();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CadastrarComanda(Models.Comanda Comanda)
        {
            #region Query

            string query = @"SELECT * 
                             FROM Comanda
                             WHERE Comanda.id = @idComanda";

            #endregion

            try
            {
                database.CreateSqlStringAccessor<Models.Comanda>(query).Execute();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

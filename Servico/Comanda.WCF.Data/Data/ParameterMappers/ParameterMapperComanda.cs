using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comanda.WCF.Data.Data.ParameterMappers
{
    public class ParameterMapperComanda : IParameterMapper
    {
        public void AssignParameters(System.Data.Common.DbCommand command, object[] parameterValues)
        {
            DbParameter idComanda = command.CreateParameter();
            idComanda.Value = parameterValues[0];
            idComanda.ParameterName = "@idComanda";

            command.Parameters.Add(idComanda);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Comanda.WCF.Service
{
    [ServiceContract]
    public interface IServiceComanda
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarProdutos?")]
        List<Models.Produto> ListarProdutos();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarComandas?")]
        List<Models.Comanda> ListarComandas();

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "CadastrarComanda?")]
        bool CadastrarComanda(Models.Comanda comanda);

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "ObterComanda?idComanda={idComanda}")]
        Models.Comanda ObterComanda(string idComanda);
    }
}

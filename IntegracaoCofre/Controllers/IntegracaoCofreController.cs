using Fadami.Helper.Database;
using IntegracaoCofre.Models;
using IntegracaoCofre.Repository;
using System.Net;
using System.Web.Http;

namespace IntegracaoCofre.Controllers
{
    public class IntegracaoCofreController : ApiController
    {
        [HttpPost]
        public ResponseStatus Status([FromBody] RequestStatus requestStatus)
        {
            try
            {
                Fadami.Helper.Logs.Log.Gravar(string.Format("Obtendo Requisição de Status - Request {0}", requestStatus), "IntegraçãoCofre", Fadami.Helper.Logs.TipoLog.Info);
                ResponseStatus response = new IntegracaoCofreRepository().ObterStatus(requestStatus);

                return response;
            }
            catch (System.Exception ex)
            {
                Fadami.Helper.Logs.Log.Gravar("Erro Requisição de Status", ex, "IntegraçãoCofre");
                return null;
            }
        }

        [HttpPost]
        public ResponseRegistrarTransacao RegistrarTransacao([FromBody] RequestRegistrarTransacao requestRegistrarTransacao)
        {
            try
            {
                Fadami.Helper.Logs.Log.Gravar(string.Format("Obtendo Requisição de Transação - Request {0}", requestRegistrarTransacao), "IntegraçãoCofre", Fadami.Helper.Logs.TipoLog.Info);
                ResponseRegistrarTransacao response = new IntegracaoCofreRepository().RegistrarTransacao(requestRegistrarTransacao);

                return response;
            }
            catch (System.Exception ex)
            {
                Fadami.Helper.Logs.Log.Gravar("Erro Requisição de Transação", ex, "IntegraçãoCofre");
                return null;
            }
        }

        [HttpPost]
        public ResponseRegistrarColeta RegistrarColeta([FromBody] RequestRegistrarColeta requestRegistrarColeta)
        {
            try
            {
                Fadami.Helper.Logs.Log.Gravar(string.Format("Obtendo Requisição de Coleta - Request {0}", requestRegistrarColeta), "IntegraçãoCofre", Fadami.Helper.Logs.TipoLog.Info);
                ResponseRegistrarColeta response = new IntegracaoCofreRepository().RegistrarColeta(requestRegistrarColeta);

                return response;
            }
            catch (System.Exception ex)
            {
                Fadami.Helper.Logs.Log.Gravar("Erro Requisição de Coleta", ex, "IntegraçãoCofre");
                return null;
            }
        }
    }
}

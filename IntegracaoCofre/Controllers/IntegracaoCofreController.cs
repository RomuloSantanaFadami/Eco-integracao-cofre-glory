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
            ResponseStatus response = new IntegracaoCofreRepository().ObterStatus(requestStatus);

            return response;
        }

        [HttpPost]
        public ResponseRegistrarTransacao RegistrarTransacao([FromBody] RequestRegistrarTransacao requestRegistrarTransacao)
        {
            ResponseRegistrarTransacao response = new IntegracaoCofreRepository().RegistrarTransacao(requestRegistrarTransacao);

            return response;
        }

        [HttpPost]
        public ResponseRegistrarColeta RegistrarColeta([FromBody] RequestRegistrarColeta requestRegistrarColeta)
        {
            ResponseRegistrarColeta response = new IntegracaoCofreRepository().RegistrarColeta(requestRegistrarColeta);

            return response;
        }
    }
}

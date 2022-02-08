using IntegracaoCofre.Models;
using System.Net;
using System.Web.Http;

namespace IntegracaoCofre.Controllers
{
    public class IntegracaoCofreController : ApiController
    {
        [HttpPost]
        public ResponseStatus Status([FromBody] RequestStatus requestStatus)
        {
            ResponseStatus response = new ResponseStatus()
            {
                ResultCode = 0,
                ResultMessage = "Sucesso"
            };

            return response;
        }
        [HttpPost]
        public ResponseRegistrarTransacao RegistrarTransacao([FromBody] RequestRegistrarTransacao requestRegistrarTransacao)
        {
            ResponseRegistrarTransacao response = new ResponseRegistrarTransacao()
            {
                ResultCode = 0,
                ResultMessage = "Sucesso",
                TransactId = 0
            };

            return response;
        }
        [HttpPost]
        public ResponseRegistrarColeta RegistrarColeta([FromBody] RequestRegistrarColeta requestRegistrarColeta)
        {
            ResponseRegistrarColeta response = new ResponseRegistrarColeta()
            {
                ResultCode = 0,
                ResultMessage = "Sucesso"
            };

            return response;
        }
    }
}

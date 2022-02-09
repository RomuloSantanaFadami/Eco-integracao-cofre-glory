using Fadami.Helper.Database;
using IntegracaoCofre.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace IntegracaoCofre.Repository
{
    public interface IIntegracaoCofreRepository
    {
        ResponseStatus ObterStatus(RequestStatus requestStatus);
        ResponseRegistrarTransacao RegistrarTransacao(RequestRegistrarTransacao requestRegistrarTransacao);
        ResponseRegistrarColeta RegistrarColeta(RequestRegistrarColeta requestRegistrarColeta);
    }
}

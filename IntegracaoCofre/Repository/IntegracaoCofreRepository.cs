using Fadami.Helper.Database;
using IntegracaoCofre.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace IntegracaoCofre.Repository
{
    public class IntegracaoCofreRepository : IIntegracaoCofreRepository
    {
        private readonly DatabaseUtil db = new DatabaseUtil();

        public ResponseStatus ObterStatus(RequestStatus requestStatus)
        {
            try
            {
                var query = string.Format("SPC_PLJ_CA_GLORY_STATUS @SERIAL_NUMBER = {0}, @SW_VERSION = {1}, @HW_SERIAL_NUMBER = {2}, @MONETARY_LIMIT = {3}",
                                            DatabaseUtil.FormatarParametro(requestStatus.SerialNumber),
                                            DatabaseUtil.FormatarParametro(requestStatus.SWVersion),
                                            DatabaseUtil.FormatarParametro(requestStatus.HwSerialNumber),
                                            DatabaseUtil.FormatarParametro(requestStatus.MonetaryLimit));

                return JsonConvert.DeserializeObject<List<ResponseStatus>>(JsonConvert.SerializeObject(db.GetDataTable(query))).FirstOrDefault();
            }
            catch (System.Exception)
            {
                return new ResponseStatus()
                {
                    ResultCode = 400,
                    ResultMessage = "Não foi posspivel processar esta requisição."
                };
            }
        }
        public ResponseRegistrarTransacao RegistrarTransacao(RequestRegistrarTransacao requestRegistrarTransacao)
        {
            try
            {

                var query = string.Format("SPI_PLJ_CA_GLORY_REGISTRAR_TRANSACAO @JSON = {0}", DatabaseUtil.FormatarParametro(JsonConvert.SerializeObject(requestRegistrarTransacao)));

                var tab = db.GetDataTable(query);

                return JsonConvert.DeserializeObject<List<ResponseRegistrarTransacao>>(JsonConvert.SerializeObject(tab)).FirstOrDefault();
            }
            catch (System.Exception ex)
            {
                return new ResponseRegistrarTransacao()
                {
                    ResultCode = 400,
                    ResultMessage = "Não foi posspivel processar esta requisição.",
                    TransactId = 0
                };
            }
        }
        public ResponseRegistrarColeta RegistrarColeta(RequestRegistrarColeta requestRegistrarColeta)
        {
            try
            {
                var query = string.Format("SPI_PLJ_CA_GLORY_REGISTRAR_COLETA @JSON = {0}", DatabaseUtil.FormatarParametro(JsonConvert.SerializeObject(requestRegistrarColeta)));

                return JsonConvert.DeserializeObject<List<ResponseRegistrarColeta>>(JsonConvert.SerializeObject(db.GetDataTable(query))).FirstOrDefault();
            }
            catch (System.Exception ex)
            {
                return new ResponseRegistrarColeta()
                {
                    ResultCode = 400,
                    ResultMessage = "Não foi posspivel processar esta requisição.",
                    TransactId = 0
                };
            }
        }
    }
}

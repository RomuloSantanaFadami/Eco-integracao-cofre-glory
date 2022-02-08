using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegracaoCofre.Models
{
    public class RequestRegistrarColeta
    {
        public int CollectionType { get; set; }
        public string SerialNumber { get; set; }
        public string ClientName { get; set; }
        public long NumeroColeta { get; set; }
        public DateTime CollectionStartDate { get; set; }
        public DateTime CollectionEndDate { get; set; }
        public string UserIdAuthor { get; set; }
        public string UserNameAuthor { get; set; }
        public string UserIdCollect { get; set; }
        public string UserNameCollect { get; set; }
        public string BagSeal { get; set; }
        public string BagSealCash { get; set; }
        public string GTVBagCash { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public List<Denomination> ListDenomination { get; set; }
        public int RecognizedBills { get; set; }
    }
}
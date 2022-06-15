using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegracaoCofre.Models
{
    public class RequestRegistrarTransacao
    {
        public string view { get; set; }
        public int TransactionType { get; set; }
        public string SerialNumber { get; set; }
        public string ClientName { get; set; }
        public long NumeroLote { get; set; }
        public DateTime TransactionDate { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int RoleId { get; set; }
        public GenId GenId1 { get; set; }
        public GenId GenId2 { get; set; }
        public GenId GenId3 { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public List<Denomination> ListDenomination { get; set; }
        public List<DenominationCoin> ListDenominationCoin { get; set; }
        public int RecognizedBills { get; set; }
        public DateTime BusDate { get; set; }
        public int ChangeTransactionId { get; set; }
    }
}
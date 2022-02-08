using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegracaoCofre.Models
{
    public class RequestStatus
    {
        public string SerialNumber { get; set; }
        public string SWVersion { get; set; }
        public string HwSerialNumber { get; set; }
        public long MonetaryLimit { get; set; }
    }
}
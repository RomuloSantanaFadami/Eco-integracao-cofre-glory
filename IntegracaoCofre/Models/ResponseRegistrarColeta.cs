﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegracaoCofre.Models
{
    public class ResponseRegistrarColeta
    {
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public long TransactId { get; set; }
    }
}
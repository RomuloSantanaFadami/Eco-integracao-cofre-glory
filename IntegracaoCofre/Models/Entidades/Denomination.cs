using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegracaoCofre.Models
{
    public class Denomination
    {
        public string RsmId { get; set; }
        public int Value { get; set; }
        public int CountInit { get; set; }
        public int Count { get; set; }
        public int CountEnd { get; set; }
    }
}
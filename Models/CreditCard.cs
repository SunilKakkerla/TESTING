using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class CreditCard
    {

        public int CardNumber { get; set; }
        public string ServiceProvider { get; set; }
        public string DateofExpire { get; set; }
        public string CVV { get; set; }
        public string Pin { get; set; }

    }
}

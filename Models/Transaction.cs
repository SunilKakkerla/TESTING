using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Transaction
    {
        public string TransactionId { get; set; }
        public int CardNumber { get; set; }
        public bool OnlineOrOffline { get; set; }
        public string ATMNumber { get; set; }
        public DateTime DateTimeDetails { get; set; }
        public string DrawnAmount { get; set; }
        public bool CanBeDrawn { get; set; }
    }
}

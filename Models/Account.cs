using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Account
    {

        public int AccountNumber { get; set; }
        public Applicant AccountantDetails { get; set; }
        public DebitCard DebitCardDetails { get; set; }
        public CreditCard CreditCardDetails { get; set; }
        public Transaction TransactionDetails { get; set; }
        public long Cash { get; set; }

    }
    
}

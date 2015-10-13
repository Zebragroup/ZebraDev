using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZebraModelLayer.Model
{
    public class Client
    {

        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientNumber { get; set; }
        public string AccountNumber { get; set; }

        public string ClientType { get; set; }
        public string ClientStatus { get; set; }

        public string Retainer { get; set; }

        public string Currency { get; set; }

        public decimal Amount { get; set; }

        public DateTime UserDateEntry { get; set; }

        public string PaymentSchedule { get; set; }

        public string UpdateUser { get; set; }

    }
}
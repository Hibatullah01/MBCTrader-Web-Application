using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MBCTrader.Models
{
    public class AccountOpening
    {
        [Key]
        public int ClientId { get; set; }
        public string ClientClass { get; set; }
        public string ClientTitle { get; set; }
        public string ClientFName { get; set; }
        public string ClientOName { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPNumber { get; set; }
        public string ClientGender { get; set; }
        public string ClientDOB { get; set; }
        public string AddressLine { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
       
    }
}

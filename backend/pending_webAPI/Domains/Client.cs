using System;
using System.Collections.Generic;

#nullable disable

namespace pending_webAPI.Domains
{
    public partial class Client
    {
        public Client()
        {
            Transactions = new HashSet<Transaction>();
        }

        public short IdClient { get; set; }
        public string NameClient { get; set; }
        public string PhoneClient { get; set; }

        public virtual CAccount CAccount { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

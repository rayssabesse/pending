using System;
using System.Collections.Generic;

#nullable disable

namespace pending_webAPI.Domains
{
    public partial class Transaction
    {
        public short IdClient { get; set; }
        public short IdTypeTransaction { get; set; }
        public short IdTransaction { get; set; }
        public decimal ValueTransaction { get; set; }
        public string DateTransaction { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual TypeTransaction IdTypeTransactionNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace pending_webAPI.Domains
{
    public partial class TypeTransaction
    {
        public TypeTransaction()
        {
            Transactions = new HashSet<Transaction>();
        }

        public short IdTypeTransaction { get; set; }
        public string NameTypeTransaction { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

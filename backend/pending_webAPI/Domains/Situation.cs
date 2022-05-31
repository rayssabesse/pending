using System;
using System.Collections.Generic;

#nullable disable

namespace pending_webAPI.Domains
{
    public partial class Situation
    {
        public Situation()
        {
            CAccounts = new HashSet<CAccount>();
        }

        public short IdSituation { get; set; }
        public string TypeSituation { get; set; }

        public virtual CashFlow CashFlow { get; set; }
        public virtual ICollection<CAccount> CAccounts { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace pending_webAPI.Domains
{
    public partial class Business
    {
        public short IdUser { get; set; }
        public short IdBAddress { get; set; }
        public short IdBusiness { get; set; }
        public string NameBusiness { get; set; }
        public string ProfitBusiness { get; set; }
        public string ExpenseBusiness { get; set; }

        public virtual BAddress IdBAddressNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
        public virtual CashFlow CashFlow { get; set; }
    }
}

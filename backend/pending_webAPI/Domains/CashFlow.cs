using System;
using System.Collections.Generic;

#nullable disable

namespace pending_webAPI.Domains
{
    public partial class CashFlow
    {
        public short IdBusiness { get; set; }
        public short IdSituation { get; set; }
        public short IdCashFlow { get; set; }
        public decimal RealBalance { get; set; }
        public decimal MonthBalance { get; set; }
        public decimal EstimatedBalance { get; set; }
        public decimal TotalExpenses { get; set; }
        //
        public decimal MonthExpenses { get; set; }
        public decimal TotalProfits { get; set; }
        public decimal MonthProfits { get; set; }
        public decimal ExpensesClients { get; set; }
        public decimal ProfitsClients { get; set; }
        public decimal OweClients { get; set; }

        public virtual Business IdBusinessNavigation { get; set; }
        public virtual Situation IdSituationNavigation { get; set; }
    }
}

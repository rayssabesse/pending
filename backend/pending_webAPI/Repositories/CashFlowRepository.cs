using pending_webAPI.Contexts;
using pending_webAPI.Domains;
using pending_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Repositories
{
    public class CashFlowRepository : ICashFlowRepository
    {

        pendingContext ctx = new pendingContext();

        public void Delete(int idCashFlow)
        {
            CashFlow SearchedCashFlow = ListId(idCashFlow);
            ctx.CashFlows.Remove(SearchedCashFlow);
            ctx.SaveChanges();
        }

        public List<CashFlow> List()
        {
            return ctx.CashFlows.ToList();
        }

        public CashFlow ListId(int idCashFlow)
        {
            return ctx.CashFlows.FirstOrDefault(c => c.IdCashFlow == idCashFlow);
        }

        public void Refresh(int idCashFlow, CashFlow CashFlowRefresh)
        {
            CashFlow SearchedCashFlow = ListId(idCashFlow);

            if (SearchedCashFlow != null)
            {
                SearchedCashFlow.IdBusiness = CashFlowRefresh.IdBusiness;
                SearchedCashFlow.IdSituation = CashFlowRefresh.IdSituation;           
                SearchedCashFlow.RealBalance = CashFlowRefresh.RealBalance;
                SearchedCashFlow.MonthBalance = CashFlowRefresh.MonthBalance;
                SearchedCashFlow.EstimatedBalance = CashFlowRefresh.EstimatedBalance;
                SearchedCashFlow.TotalExpenses = CashFlowRefresh.TotalExpenses;
                SearchedCashFlow.MonthExpenses = CashFlowRefresh.MonthExpenses;
                SearchedCashFlow.TotalProfits = CashFlowRefresh.TotalProfits;
                SearchedCashFlow.MonthProfits = CashFlowRefresh.MonthProfits;
                SearchedCashFlow.ExpensesClients = CashFlowRefresh.ExpensesClients;
                SearchedCashFlow.ProfitsClients = CashFlowRefresh.ProfitsClients;
                SearchedCashFlow.OweClients = CashFlowRefresh.OweClients;


            }

            ctx.CashFlows.Update(SearchedCashFlow);

            ctx.SaveChanges();
        }

        public void Register(CashFlow newCashFlow)
        {
            ctx.CashFlows.Add(newCashFlow);
            ctx.SaveChanges();
        }
    }
}

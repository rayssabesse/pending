using pending_webAPI.Contexts;
using pending_webAPI.Domains;
using pending_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Repositories
{
    public class CAccountRepository : ICAccountRepository
    {

        pendingContext ctx = new pendingContext();

        public void Delete(int idCAccount)
        {
            CAccount SearchedCAccount = ListId(idCAccount);
            ctx.CAccounts.Remove(SearchedCAccount);
            ctx.SaveChanges();
        }

        public List<CAccount> List()
        {
            return ctx.CAccounts.ToList();
        }

        public CAccount ListId(int idCAccount)
        {
            return ctx.CAccounts.FirstOrDefault(c => c.IdCAccount == idCAccount);
        }

        public void Refresh(int idCAccount, CAccount CAccountRefresh)
        {
            CAccount SearchedCAccount = ListId(idCAccount);

            if (SearchedCAccount != null)
            {
                SearchedCAccount.IdClient = CAccountRefresh.IdClient;
                SearchedCAccount.IdSituation = CAccountRefresh.IdSituation;
                SearchedCAccount.Balance = CAccountRefresh.Balance;
            }

            ctx.CAccounts.Update(SearchedCAccount);

            ctx.SaveChanges();
        }

        public void Register(CAccount newCAccount)
        {
            ctx.CAccounts.Add(newCAccount);
            ctx.SaveChanges();
        }
    }
}

using pending_webAPI.Contexts;
using pending_webAPI.Domains;
using pending_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Repositories
{
    
    public class TransactionRepository : ITransactionRepository
    {

        pendingContext ctx = new pendingContext();

        public void Delete(int idTransaction)
        {
            Transaction SearchedTransaction = ListId(idTransaction);
            ctx.Transactions.Remove(SearchedTransaction);
            ctx.SaveChanges();
        }

        public List<Transaction> List()
        {
            return ctx.Transactions.ToList();
        }

        public Transaction ListId(int idTransaction)
        {
            return ctx.Transactions.FirstOrDefault(c => c.IdTransaction == idTransaction);
        }

        public void Refresh(int idTransaction, Transaction TransactionRefresh)
        {
            Transaction SearchedTransaction = ListId(idTransaction);

            if (SearchedTransaction != null)
            {
                SearchedTransaction.IdClient = TransactionRefresh.IdClient;
                SearchedTransaction.IdTypeTransaction = TransactionRefresh.IdTypeTransaction;
                SearchedTransaction.ValueTransaction = TransactionRefresh.ValueTransaction;
                SearchedTransaction.DateTransaction = TransactionRefresh.DateTransaction;



            }

            ctx.Transactions.Update(SearchedTransaction);

            ctx.SaveChanges();
        }

        public void Register(Transaction newTransaction)
        {
            ctx.Transactions.Add(newTransaction);
            ctx.SaveChanges();
        }

    }
}

using pending_webAPI.Contexts;
using pending_webAPI.Domains;
using pending_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Repositories
{
    public class TypeTransactionRepository : ITypeTransactionRepository
    {

        pendingContext ctx = new pendingContext();

        public void Delete(int idTypeTransaction)
        {
            TypeTransaction SearchedTypeTransaction = ListId(idTypeTransaction);
            ctx.TypeTransactions.Remove(SearchedTypeTransaction);
            ctx.SaveChanges();
        }

        public List<TypeTransaction> List()
        {
            return ctx.TypeTransactions.ToList();
        }

        public TypeTransaction ListId(int idTypeTransaction)
        {
            return ctx.TypeTransactions.FirstOrDefault(c => c.IdTypeTransaction == idTypeTransaction);
        }

        public void Refresh(int idTypeTransaction, TypeTransaction TypeTransactionRefresh)
        {
            TypeTransaction SearchedTypeTransaction = ListId(idTypeTransaction);

            if (SearchedTypeTransaction != null)
            {
                SearchedTypeTransaction.NameTypeTransaction = TypeTransactionRefresh.NameTypeTransaction;

            }

            ctx.TypeTransactions.Update(SearchedTypeTransaction);

            ctx.SaveChanges();
        }

        public void Register(TypeTransaction newTypeTransaction)
        {
            ctx.TypeTransactions.Add(newTypeTransaction);
            ctx.SaveChanges();
        }
    }
}

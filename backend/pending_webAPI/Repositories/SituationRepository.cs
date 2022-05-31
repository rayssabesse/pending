using pending_webAPI.Contexts;
using pending_webAPI.Domains;
using pending_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Repositories
{
    public class SituationRepository : ISituationRepository
    {

        pendingContext ctx = new pendingContext();

        public void Delete(int idSituation)
        {
            Situation SearchedSituation = ListId(idSituation);
            ctx.Situations.Remove(SearchedSituation);
            ctx.SaveChanges();
        }

        public List<Situation> List()
        {
            return ctx.Situations.ToList();
        }

        public Situation ListId(int idSituation)
        {
            return ctx.Situations.FirstOrDefault(c => c.IdSituation == idSituation);
        }

        public void Refresh(int idSituation, Situation SituationRefresh)
        {
            Situation SearchedSituation = ListId(idSituation);

            if (SearchedSituation != null)
            {
                SearchedSituation.TypeSituation = SituationRefresh.TypeSituation;

            }

            ctx.Situations.Update(SearchedSituation);

            ctx.SaveChanges();
        }

        public void Register(Situation newSituation)
        {
            ctx.Situations.Add(newSituation);
            ctx.SaveChanges();
        }
    }
}

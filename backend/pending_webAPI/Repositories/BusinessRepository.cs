using pending_webAPI.Contexts;
using pending_webAPI.Domains;
using pending_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Repositories
{
    public class BusinessRepository : IBusinessRepository
    {

        pendingContext ctx = new pendingContext();

        public void Delete(int idBusiness)
        {
            Business SearchedBusiness = ListId(idBusiness);
            ctx.Businesses.Remove(SearchedBusiness);
            ctx.SaveChanges();
        }

        public List<Business> List()
        {
            return ctx.Businesses.ToList();
        }

        public Business ListId(int idBusiness)
        {
            return ctx.Businesses.FirstOrDefault(c => c.IdBusiness == idBusiness);
        }

        public void Refresh(int idBusiness, Business BusinessRefresh)
        {
            Business SearchedBusiness = ListId(idBusiness);

            if (SearchedBusiness != null)
            {
                SearchedBusiness.IdUser = BusinessRefresh.IdUser;
                SearchedBusiness.IdBAddress = BusinessRefresh.IdBAddress;
                SearchedBusiness.NameBusiness = BusinessRefresh.NameBusiness;
                SearchedBusiness.ProfitBusiness = BusinessRefresh.ProfitBusiness;
                SearchedBusiness.ExpenseBusiness = BusinessRefresh.ExpenseBusiness;
              

            }

            ctx.Businesses.Update(SearchedBusiness);

            ctx.SaveChanges();
        }

        public void Register(Business newBusiness)
        {
            ctx.Businesses.Add(newBusiness);
            ctx.SaveChanges();
        }
    }
}

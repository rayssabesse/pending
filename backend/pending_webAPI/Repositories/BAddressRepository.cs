using pending_webAPI.Contexts;
using pending_webAPI.Domains;
using pending_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Repositories
{
    public class BAddressRepository : IBAddressRepository
    {
        //int BAddressRepository();

        pendingContext ctx = new pendingContext();

        public void Delete(int idBAddress)
        {
            BAddress SearchedBAddress = ListId(idBAddress);
            ctx.BAddresses.Remove(SearchedBAddress);
            ctx.SaveChanges();
        }

        public List<BAddress> List()
        {
            return ctx.BAddresses.ToList();
        }

        public BAddress ListId(int idBAddress)
        {
            return ctx.BAddresses.FirstOrDefault(c => c.IdBAddress == idBAddress);
        }

        public void Refresh(int idBAddress, BAddress BAddressRefresh)
        {
            BAddress SearchedBAddress = ListId(idBAddress);

            if (SearchedBAddress != null)
            {
                SearchedBAddress.IdUser = BAddressRefresh.IdUser;
                SearchedBAddress.Street = BAddressRefresh.Street;
                SearchedBAddress.Number = BAddressRefresh.Number;
                SearchedBAddress.Neighborhood = BAddressRefresh.Neighborhood;
                SearchedBAddress.City = BAddressRefresh.City;
                SearchedBAddress.Zipcode = BAddressRefresh.Zipcode;


            }

            ctx.BAddresses.Update(SearchedBAddress);

            ctx.SaveChanges();
        }

        public void Register(BAddress newBAddress)
        {
            ctx.BAddresses.Add(newBAddress);
            ctx.SaveChanges();
        }

    }
}

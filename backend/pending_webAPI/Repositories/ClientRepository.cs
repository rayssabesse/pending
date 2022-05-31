using pending_webAPI.Contexts;
using pending_webAPI.Domains;
using pending_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Repositories
{
    public class ClientRepository : IClientRepository
    {

        pendingContext ctx = new pendingContext();

        public void Delete(int idClient)
        {
            Client SearchedClient = ListId(idClient);
            ctx.Clients.Remove(SearchedClient);
            ctx.SaveChanges();
        }

        public List<Client> List()
        {
            return ctx.Clients.ToList();
        }

        public Client ListId(int idClient)
        {
            return ctx.Clients.FirstOrDefault(c => c.IdClient == idClient);
        }

        public void Refresh(int idClient, Client clientRefresh)
        {
            Client SearchedClient = ListId(idClient);

            if (SearchedClient != null)
            {
                SearchedClient.NameClient = clientRefresh.NameClient;
                SearchedClient.PhoneClient = clientRefresh.PhoneClient;

            }

            ctx.Clients.Update(SearchedClient);

            ctx.SaveChanges();
        }

        public void Register(Client newClient)
        {
            ctx.Clients.Add(newClient);
            ctx.SaveChanges();
        }
    }
}

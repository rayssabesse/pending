using pending_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Interfaces
{
    interface IClientRepository
    {

        /// <summary>
        /// Lista todos os Clientes
        /// </summary>
        /// <returns>Uma lista de Clientes</returns>
        List<Client> List();

        /// <summary>
        /// Busca um Cliente por seu Id
        /// </summary>
        /// <param name="idClient">Id do Cliente</param>
        /// <returns>Cliente buscado</returns>
        Client ListId(int idClient);

        /// <summary>
        /// Cadastra um Cliente
        /// </summary>
        /// <param name="newClient">Objeto novoCliente com os novos dados</param>
        void Register(Client newClient);

        /// <summary>
        /// Atualiza um Cliente específico
        /// </summary>
        /// <param name="idClient">Id do Cliente atualizado</param>
        /// <param name="clientRefresh">ClienteAtualizado com os novos dados</param>
        void Refresh(int idClient, Client clientRefresh);

        /// <summary>
        /// Deleta um Cliente específico
        /// </summary>
        /// <param name="idClient">Id do Cliente deletado</param>
        void Delete(int idClient);

    }
}

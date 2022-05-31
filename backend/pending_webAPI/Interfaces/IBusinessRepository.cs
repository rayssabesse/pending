using pending_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Interfaces
{
    interface IBusinessRepository
    {

        /// <summary>
        /// Lista todos os Businesses
        /// </summary>
        /// <returns>Uma lista de Businesses</returns>
        List<Business> List();

        /// <summary>
        /// Busca um Businesse por seu Id
        /// </summary>
        /// <param name="idBusiness">Id do Businesse</param>
        /// <returns>Businesse buscado</returns>
        Business ListId(int idBusiness);

        /// <summary>
        /// Cadastra um Businesse
        /// </summary>
        /// <param name="newBusiness">Objeto novoBusinesse com os novos dados</param>
        void Register(Business newBusiness);

        /// <summary>
        /// Atualiza um Businesse específico
        /// </summary>
        /// <param name="idBusiness">Id do Businesse atualizado</param>
        /// <param name="BusinessRefresh">BusinesseAtualizado com os novos dados</param>
        void Refresh(int idBusiness, Business BusinessRefresh);

        /// <summary>
        /// Deleta um Businesse específico
        /// </summary>
        /// <param name="idBusiness">Id do Businesse deletado</param>
        void Delete(int idBusiness);

    }
}

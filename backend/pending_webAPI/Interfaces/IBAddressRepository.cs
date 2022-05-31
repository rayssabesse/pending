using pending_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Interfaces
{
    interface IBAddressRepository
    {

        /// <summary>
        /// Lista todos os BAddresses
        /// </summary>
        /// <returns>Uma lista de BAddresses</returns>
        List<BAddress> List();

        /// <summary>
        /// Busca um BAddresse por seu Id
        /// </summary>
        /// <param name="idBAddress">Id do BAddresse</param>
        /// <returns>BAddresse buscado</returns>
        BAddress ListId(int idBAddress);

        /// <summary>
        /// Cadastra um BAddresse
        /// </summary>
        /// <param name="newBAddress">Objeto novoBAddresse com os novos dados</param>
        void Register(BAddress newBAddress);

        /// <summary>
        /// Atualiza um BAddresse específico
        /// </summary>
        /// <param name="idBAddress">Id do BAddresse atualizado</param>
        /// <param name="BAddressRefresh">BAddresseAtualizado com os novos dados</param>
        void Refresh(int idBAddress, BAddress BAddressRefresh);

        /// <summary>
        /// Deleta um BAddresse específico
        /// </summary>
        /// <param name="idBAddress">Id do BAddresse deletado</param>
        void Delete(int idBAddress);

    }
}

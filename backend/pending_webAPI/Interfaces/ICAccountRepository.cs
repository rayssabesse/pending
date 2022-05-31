using pending_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Interfaces
{
    interface ICAccountRepository
    {

        /// <summary>
        /// Lista todos os CAccountes
        /// </summary>
        /// <returns>Uma lista de CAccountes</returns>
        List<CAccount> List();

        /// <summary>
        /// Busca um CAccounte por seu Id
        /// </summary>
        /// <param name="idCAccount">Id do CAccounte</param>
        /// <returns>CAccounte buscado</returns>
        CAccount ListId(int idCAccount);

        /// <summary>
        /// Cadastra um CAccounte
        /// </summary>
        /// <param name="newCAccount">Objeto novoCAccounte com os novos dados</param>
        void Register(CAccount newCAccount);

        /// <summary>
        /// Atualiza um CAccounte específico
        /// </summary>
        /// <param name="idCAccount">Id do CAccounte atualizado</param>
        /// <param name="CAccountRefresh">CAccounteAtualizado com os novos dados</param>
        void Refresh(int idCAccount, CAccount CAccountRefresh);

        /// <summary>
        /// Deleta um CAccounte específico
        /// </summary>
        /// <param name="idCAccount">Id do CAccounte deletado</param>
        void Delete(int idCAccount);

    }
}

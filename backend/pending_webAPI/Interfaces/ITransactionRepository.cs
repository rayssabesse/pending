using pending_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Interfaces
{
    interface ITransactionRepository
    {

        /// <summary>
        /// Lista todos os Transaction
        /// </summary>
        /// <returns>Uma lista de Transaction</returns>
        List<Transaction> List();

        /// <summary>
        /// Busca uma Transaction por seu Id
        /// </summary>
        /// <param name="idTransaction">Id do CliTransactionente</param>
        /// <returns>Cliente buscado</returns>
        Transaction ListId(int idTransaction);

        /// <summary>
        /// Cadastra uma Transaction
        /// </summary>
        /// <param name="newTransaction">Objeto novaTransaction com os novos dados</param>
        void Register(Transaction newTransaction);

        /// <summary>
        /// Atualiza um Cliente específico
        /// </summary>
        /// <param name="idTransaction">Id do Transaction atualizado</param>
        /// <param name="TrasactionRefresh">TransactionAtualizado com os novos dados</param>
        void Refresh(int idTransaction, Transaction TrasactionRefresh);

        /// <summary>
        /// Deleta uma Transaction específico
        /// </summary>
        /// <param name="idTransaction">Id da Transaction deletado</param>
        void Delete(int idTransaction);

    }
}

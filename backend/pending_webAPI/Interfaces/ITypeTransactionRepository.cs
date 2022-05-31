using pending_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Interfaces
{
    interface ITypeTransactionRepository
    {

        /// <summary>
        /// Lista todos os TypeTransactiones
        /// </summary>
        /// <returns>Uma lista de TypeTransactiones</returns>
        List<TypeTransaction> List();

        /// <summary>
        /// Busca um TypeTransactione por seu Id
        /// </summary>
        /// <param name="idTypeTransaction">Id do TypeTransactione</param>
        /// <returns>TypeTransactione buscado</returns>
        TypeTransaction ListId(int idTypeTransaction);

        /// <summary>
        /// Cadastra um TypeTransactione
        /// </summary>
        /// <param name="newTypeTransaction">Objeto novoTypeTransactione com os novos dados</param>
        void Register(TypeTransaction newTypeTransaction);

        /// <summary>
        /// Atualiza um TypeTransactione específico
        /// </summary>
        /// <param name="idTypeTransaction">Id do TypeTransactione atualizado</param>
        /// <param name="TypeTransactionRefresh">TypeTransactioneAtualizado com os novos dados</param>
        void Refresh(int idTypeTransaction, TypeTransaction TypeTransactionRefresh);

        /// <summary>
        /// Deleta um TypeTransactione específico
        /// </summary>
        /// <param name="idTypeTransaction">Id do TypeTransactione deletado</param>
        void Delete(int idTypeTransaction);

    }
}

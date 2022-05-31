using pending_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Interfaces
{
    interface ICashFlowRepository
    {

        /// <summary>
        /// Lista todos os CashFlowes
        /// </summary>
        /// <returns>Uma lista de CashFlowes</returns>
        List<CashFlow> List();

        /// <summary>
        /// Busca um CashFlowe por seu Id
        /// </summary>
        /// <param name="idCashFlow">Id do CashFlowe</param>
        /// <returns>CashFlowe buscado</returns>
        CashFlow ListId(int idCashFlow);

        /// <summary>
        /// Cadastra um CashFlowe
        /// </summary>
        /// <param name="newCashFlow">Objeto novoCashFlowe com os novos dados</param>
        void Register(CashFlow newCashFlow);

        /// <summary>
        /// Atualiza um CashFlowe específico
        /// </summary>
        /// <param name="idCashFlow">Id do CashFlowe atualizado</param>
        /// <param name="CashFlowRefresh">CashFloweAtualizado com os novos dados</param>
        void Refresh(int idCashFlow, CashFlow CashFlowRefresh);

        /// <summary>
        /// Deleta um CashFlowe específico
        /// </summary>
        /// <param name="idCashFlow">Id do CashFlowe deletado</param>
        void Delete(int idCashFlow);

    }
}

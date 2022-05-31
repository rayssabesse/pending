using pending_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Interfaces
{
    interface ISituationRepository
    {

        /// <summary>
        /// Lista todos os Situationes
        /// </summary>
        /// <returns>Uma lista de Situationes</returns>
        List<Situation> List();

        /// <summary>
        /// Busca um Situatione por seu Id
        /// </summary>
        /// <param name="idSituation">Id do Situatione</param>
        /// <returns>Situatione buscado</returns>
        Situation ListId(int idSituation);

        /// <summary>
        /// Cadastra um Situatione
        /// </summary>
        /// <param name="newSituation">Objeto novoSituatione com os novos dados</param>
        void Register(Situation newSituation);

        /// <summary>
        /// Atualiza um Situatione específico
        /// </summary>
        /// <param name="idSituation">Id do Situatione atualizado</param>
        /// <param name="SituationRefresh">SituationeAtualizado com os novos dados</param>
        void Refresh(int idSituation, Situation SituationRefresh);

        /// <summary>
        /// Deleta um Situatione específico
        /// </summary>
        /// <param name="idSituation">Id do Situatione deletado</param>
        void Delete(int idSituation);

    }
}

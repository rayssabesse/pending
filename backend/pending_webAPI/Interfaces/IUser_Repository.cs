using pending_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Interfaces
{
    interface IUser_Repository
    {

        /// <summary>
        /// validate user
        /// </summary>
        /// <param name="email"> email user </param>
        /// <param name="password"> password user </param>
        /// <returns> user login </returns>
        User Login(string email, string password);

        /// <summary>
        /// List all user
        /// </summary>
        /// <returns>list user</returns>
        List<User> List();


        /// <summary>
        /// register user
        /// </summary>
        /// <param name="newUser">newUser</param>
        void Register(User newUser);

        /// <summary>
        /// Refresh user specific
        /// </summary>
        /// <param name="idUser">Id do Usuario atualizado</param>
        /// <param name="userRefresh">UsuarioAtualizado com os novos dados</param>
        /// 

        ////////////////////////////Continuar
        void Refresh(int idUser, User userRefresh);

        /// <summary>
        /// Deleta um Usuario específico
        /// </summary>
        /// <param name="idUser">Id do Usuario deletado</param>
        void Delete(int idUser);

        /// <summary>
        /// Busca um Usuario por seu Id
        /// </summary>
        /// <param name="id">Id do Usuario</param>
        /// <returns>Usuario buscado</returns>
        User ListId(int id);


    }
}

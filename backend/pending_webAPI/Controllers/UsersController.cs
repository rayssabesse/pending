using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pending_webAPI.Domains;
using pending_webAPI.Interfaces;
using pending_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUser_Repository _UserRepository { get; set; }

        public UsersController()
        {
            _UserRepository = new User_Repository();
        }

        /// <summary>
        /// List all Users
        /// </summary>
        /// <returns>list user status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            List<User> listUsers = _UserRepository.List();
            return Ok(listUsers);
        }

        /// <summary>
        /// Busca um Usuario através de seu ID
        /// </summary>
        /// <param name="id">ID do Usuario buscado</param>
        /// <returns>O Usuario buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            User SearchedUser = _UserRepository.ListId(id);

            if (SearchedUser == null)
            {
                return NotFound("Nenhum Usuario encontrado.");
            }

            return Ok(SearchedUser);
        }

        /// <summary>
        /// Cadastra um novo Usuario
        /// </summary>
        /// <param name="newUser">Objeto novoUsuario com os novos dados</param>
        [HttpPost]
        public IActionResult Post(User newUser)
        {
            _UserRepository.Register(newUser);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um Usuario existente
        /// </summary>
        /// <param name="id">ID do Usuario deletado</param>
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _UserRepository.Delete(id);
            return StatusCode(204);
        }


        /// <summary>
        /// Atualiza um Usuario existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="id">id do Usuario que será atualizado</param>
        /// <param name="userRefresh">Objeto UsuarioAtualizado com os novos dados</param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, User userRefresh)
        {
            User SearchedUser = _UserRepository.ListId(id);

            if (SearchedUser == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Usuario não encontrado.",
                        erro = true
                    });
            }

            try
            {
                _UserRepository.Refresh(id, userRefresh);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


    }
}

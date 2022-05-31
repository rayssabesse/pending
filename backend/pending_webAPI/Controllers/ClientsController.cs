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
    public class ClientsController : ControllerBase
    {
        private IClientRepository _ClientRepository { get; set; }

        public ClientsController()
        {
            _ClientRepository = new ClientRepository();
        }

        /// <summary>
        /// List all Clients
        /// </summary>
        /// <returns>list Client status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            List<Client> listClients = _ClientRepository.List();
            return Ok(listClients);
        }

        /// <summary>
        /// Busca um Cliente através de seu ID
        /// </summary>
        /// <param name="id">ID do Cliente buscado</param>
        /// <returns>O Client buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Client SearchedClient = _ClientRepository.ListId(id);

            if (SearchedClient == null)
            {
                return NotFound("Nenhuma Conta encontrada.");
            }

            return Ok(SearchedClient);
        }

        /// <summary>
        /// Cadastra um novo Cliente
        /// </summary>
        /// <param name="newClient">Objeto novoCliente com os novos dados</param>
        [HttpPost]
        public IActionResult Post(Client newClient)
        {
            _ClientRepository.Register(newClient);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um Client existente
        /// </summary>
        /// <param name="id">ID do Client deletado</param>
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _ClientRepository.Delete(id);
            return StatusCode(204);
        }


        /// <summary>
        /// Atualiza um Client existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="id">id do Client que será atualizado</param>
        /// <param name="ClientRefresh">Objeto ClientAtualizado com os novos dados</param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Client ClientRefresh)
        {
            Client SearchedClient = _ClientRepository.ListId(id);

            if (SearchedClient == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Conta não encontrada.",
                        erro = true
                    });
            }

            try
            {
                _ClientRepository.Refresh(id, ClientRefresh);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


    }
}

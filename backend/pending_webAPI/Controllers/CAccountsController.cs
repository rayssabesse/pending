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
    public class CAccountsController : ControllerBase
    {
        private ICAccountRepository _CAccountRepository { get; set; }

        public CAccountsController()
        {
            _CAccountRepository = new CAccountRepository();
        }

        /// <summary>
        /// List all CAccounts
        /// </summary>
        /// <returns>list CAccount status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            List<CAccount> listCAccounts = _CAccountRepository.List();
            return Ok(listCAccounts);
        }

        /// <summary>
        /// Busca um CAccounte através de seu ID
        /// </summary>
        /// <param name="id">ID do CAccounte buscado</param>
        /// <returns>O CAccount buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            CAccount SearchedCAccount = _CAccountRepository.ListId(id);

            if (SearchedCAccount == null)
            {
                return NotFound("Nenhuma Conta encontrada.");
            }

            return Ok(SearchedCAccount);
        }

        /// <summary>
        /// Cadastra um novo CAccounte
        /// </summary>
        /// <param name="newCAccount">Objeto novoCAccounte com os novos dados</param>
        [HttpPost]
        public IActionResult Post(CAccount newCAccount)
        {
            _CAccountRepository.Register(newCAccount);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um CAccount existente
        /// </summary>
        /// <param name="id">ID do CAccount deletado</param>
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _CAccountRepository.Delete(id);
            return StatusCode(204);
        }


        /// <summary>
        /// Atualiza um CAccount existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="id">id do CAccount que será atualizado</param>
        /// <param name="CAccountRefresh">Objeto CAccountAtualizado com os novos dados</param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, CAccount CAccountRefresh)
        {
            CAccount SearchedCAccount = _CAccountRepository.ListId(id);

            if (SearchedCAccount == null)
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
                _CAccountRepository.Refresh(id, CAccountRefresh);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


    }
}

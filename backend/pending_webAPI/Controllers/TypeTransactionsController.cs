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
    public class TypeTransactionsController : ControllerBase
    {
        private ITypeTransactionRepository _TypeTransactionRepository { get; set; }

        public TypeTransactionsController()
        {
            _TypeTransactionRepository = new TypeTransactionRepository();
        }

        /// <summary>
        /// List all TypeTransactions
        /// </summary>
        /// <returns>list TypeTransaction status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            List<TypeTransaction> listTypeTransactions = _TypeTransactionRepository.List();
            return Ok(listTypeTransactions);
        }

        /// <summary>
        /// Busca um TypeTransactione através de seu ID
        /// </summary>
        /// <param name="id">ID do TypeTransactione buscado</param>
        /// <returns>O TypeTransaction buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            TypeTransaction SearchedTypeTransaction = _TypeTransactionRepository.ListId(id);

            if (SearchedTypeTransaction == null)
            {
                return NotFound("Nenhum TypeTransactione encontrado.");
            }

            return Ok(SearchedTypeTransaction);
        }

        /// <summary>
        /// Cadastra um novo TypeTransactione
        /// </summary>
        /// <param name="newTypeTransaction">Objeto novoTypeTransactione com os novos dados</param>
        [HttpPost]
        public IActionResult Post(TypeTransaction newTypeTransaction)
        {
            _TypeTransactionRepository.Register(newTypeTransaction);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um TypeTransaction existente
        /// </summary>
        /// <param name="id">ID do TypeTransaction deletado</param>
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _TypeTransactionRepository.Delete(id);
            return StatusCode(204);
        }


        /// <summary>
        /// Atualiza um TypeTransaction existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="id">id do TypeTransaction que será atualizado</param>
        /// <param name="TypeTransactionRefresh">Objeto TypeTransactionAtualizado com os novos dados</param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, TypeTransaction TypeTransactionRefresh)
        {
            TypeTransaction SearchedTypeTransaction = _TypeTransactionRepository.ListId(id);

            if (SearchedTypeTransaction == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "TypeTransactione não encontrado.",
                        erro = true
                    });
            }

            try
            {
                _TypeTransactionRepository.Refresh(id, TypeTransactionRefresh);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


    }
}

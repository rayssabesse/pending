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
    public class TransactionsController : ControllerBase
    {
        private ITransactionRepository _TransactionRepository { get; set; }

        public TransactionsController()
        {
            _TransactionRepository = new TransactionRepository();
        }

        /// <summary>
        /// List all Transactions
        /// </summary>
        /// <returns>list Transaction status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            List<Transaction> listTransactions = _TransactionRepository.List();
            return Ok(listTransactions);
        }

        /// <summary>
        /// Busca uma Transação através de seu ID
        /// </summary>
        /// <param name="id">ID da Transação buscado</param>
        /// <returns>A Transação buscada</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Transaction SearchedTransaction = _TransactionRepository.ListId(id);

            if (SearchedTransaction == null)
            {
                return NotFound("Nenhuma Transação encontrada.");
            }

            return Ok(SearchedTransaction);
        }

        /// <summary>
        /// Cadastra uma nova Transação
        /// </summary>
        /// <param name="newTransaction">Objeto novaTransação com os novos dados</param>
        [HttpPost]
        public IActionResult Post(Transaction newTransaction)
        {
            _TransactionRepository.Register(newTransaction);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta uma Transação existente
        /// </summary>
        /// <param name="id">ID da Transação deletada</param>
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _TransactionRepository.Delete(id);
            return StatusCode(204);
        }


        /// <summary>
        /// Atualiza uma Transação existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="id">id da Transação que será atualizado</param>
        /// <param name="TransactionRefresh">Objeto TransaçãoAtualizado com os novos dados</param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Transaction TransactionRefresh)
        {
            Transaction SearchedTransaction = _TransactionRepository.ListId(id);

            if (SearchedTransaction == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Transação não encontrada.",
                        erro = true
                    });
            }

            try
            {
                _TransactionRepository.Refresh(id, TransactionRefresh);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


    }
}

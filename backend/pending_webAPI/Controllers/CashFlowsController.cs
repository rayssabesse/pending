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
    public class CashFlowsController : ControllerBase
    {
        private ICashFlowRepository _CashFlowRepository { get; set; }

        public CashFlowsController()
        {
            _CashFlowRepository = new CashFlowRepository();
        }

        /// <summary>
        /// List all CashFlows
        /// </summary>
        /// <returns>list CashFlow status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            List<CashFlow> listCashFlows = _CashFlowRepository.List();
            return Ok(listCashFlows);
        }

        /// <summary>
        /// Busca um CashFlow através de seu ID
        /// </summary>
        /// <param name="id">ID do CashFlowe buscado</param>
        /// <returns>O CashFlow buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            CashFlow SearchedCashFlow = _CashFlowRepository.ListId(id);

            if (SearchedCashFlow == null)
            {
                return NotFound("Nenhum caixa encontrado.");
            }

            return Ok(SearchedCashFlow);
        }

        /// <summary>
        /// Cadastra um novo CashFlowe
        /// </summary>
        /// <param name="newCashFlow">Objeto novoCashFlowe com os novos dados</param>
        [HttpPost]
        public IActionResult Post(CashFlow newCashFlow)
        {
            _CashFlowRepository.Register(newCashFlow);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um CashFlow existente
        /// </summary>
        /// <param name="id">ID do CashFlow deletado</param>
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _CashFlowRepository.Delete(id);
            return StatusCode(204);
        }


        /// <summary>
        /// Atualiza um CashFlow existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="id">id do CashFlow que será atualizado</param>
        /// <param name="CashFlowRefresh">Objeto CashFlowAtualizado com os novos dados</param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, CashFlow CashFlowRefresh)
        {
            CashFlow SearchedCashFlow = _CashFlowRepository.ListId(id);

            if (SearchedCashFlow == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Caixa não encontrado.",
                        erro = true
                    });
            }

            try
            {
                _CashFlowRepository.Refresh(id, CashFlowRefresh);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


    }
}

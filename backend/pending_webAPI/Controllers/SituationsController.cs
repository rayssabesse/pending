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
    public class SituationsController : ControllerBase
    {
        private ISituationRepository _SituationRepository { get; set; }

        public SituationsController()
        {
            _SituationRepository = new SituationRepository();
        }

        /// <summary>
        /// List all Situations
        /// </summary>
        /// <returns>list Situation status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            List<Situation> listSituations = _SituationRepository.List();
            return Ok(listSituations);
        }

        /// <summary>
        /// Busca um Situatione através de seu ID
        /// </summary>
        /// <param name="id">ID do Situatione buscado</param>
        /// <returns>O Situation buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Situation SearchedSituation = _SituationRepository.ListId(id);

            if (SearchedSituation == null)
            {
                return NotFound("Nenhuma Situação encontrada.");
            }

            return Ok(SearchedSituation);
        }

        /// <summary>
        /// Cadastra um novo Situatione
        /// </summary>
        /// <param name="newSituation">Objeto novoSituatione com os novos dados</param>
        [HttpPost]
        public IActionResult Post(Situation newSituation)
        {
            _SituationRepository.Register(newSituation);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um Situation existente
        /// </summary>
        /// <param name="id">ID do Situation deletado</param>
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _SituationRepository.Delete(id);
            return StatusCode(204);
        }


        /// <summary>
        /// Atualiza um Situation existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="id">id do Situation que será atualizado</param>
        /// <param name="SituationRefresh">Objeto SituationAtualizado com os novos dados</param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Situation SituationRefresh)
        {
            Situation SearchedSituation = _SituationRepository.ListId(id);

            if (SearchedSituation == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Situação não encontrada.",
                        erro = true
                    });
            }

            try
            {
                _SituationRepository.Refresh(id, SituationRefresh);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


    }
}

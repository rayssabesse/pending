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
    public class BusinessesController : ControllerBase
    {
        private IBusinessRepository _BusinessRepository { get; set; }

        public BusinessesController()
        {
            _BusinessRepository = new BusinessRepository();
        }

        /// <summary>
        /// List all Businesses
        /// </summary>
        /// <returns>list Business status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            List<Business> listBusinesses = _BusinessRepository.List();
            return Ok(listBusinesses);
        }

        /// <summary>
        /// Busca um Businesse através de seu ID
        /// </summary>
        /// <param name="id">ID do Businesse buscado</param>
        /// <returns>O Business buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Business SearchedBusiness = _BusinessRepository.ListId(id);

            if (SearchedBusiness == null)
            {
                return NotFound("Nenhum estabelecimento encontrado.");
            }

            return Ok(SearchedBusiness);
        }

        /// <summary>
        /// Cadastra um novo Businesse
        /// </summary>
        /// <param name="newBusiness">Objeto novoBusinesse com os novos dados</param>
        [HttpPost]
        public IActionResult Post(Business newBusiness)
        {
            _BusinessRepository.Register(newBusiness);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um Business existente
        /// </summary>
        /// <param name="id">ID do Business deletado</param>
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _BusinessRepository.Delete(id);
            return StatusCode(204);
        }


        /// <summary>
        /// Atualiza um Business existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="id">id do Business que será atualizado</param>
        /// <param name="BusinessRefresh">Objeto BusinessAtualizado com os novos dados</param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Business BusinessRefresh)
        {
            Business SearchedBusiness = _BusinessRepository.ListId(id);

            if (SearchedBusiness == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "estabelecimento não encontrado.",
                        erro = true
                    });
            }

            try
            {
                _BusinessRepository.Refresh(id, BusinessRefresh);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


    }
}

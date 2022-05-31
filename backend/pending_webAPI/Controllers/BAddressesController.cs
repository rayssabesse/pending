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
    public class BAddressesController : ControllerBase
    {
        private IBAddressRepository _BAddressRepository { get; set; }

        public BAddressesController()
        {
            _BAddressRepository = new BAddressRepository();
        }

        /// <summary>
        /// List all BAddresses
        /// </summary>
        /// <returns>list BAddress status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            List<BAddress> listBAddresses = _BAddressRepository.List();
            return Ok(listBAddresses);
        }

        /// <summary>
        /// Busca um BAddresse através de seu ID
        /// </summary>
        /// <param name="id">ID do BAddresse buscado</param>
        /// <returns>O BAddress buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            BAddress SearchedBAddress = _BAddressRepository.ListId(id);

            if (SearchedBAddress == null)
            {
                return NotFound("Nenhum endereço encontrado.");
            }

            return Ok(SearchedBAddress);
        }

        /// <summary>
        /// Cadastra um novo BAddresse
        /// </summary>
        /// <param name="newBAddress">Objeto novoBAddresse com os novos dados</param>
        [HttpPost]
        public IActionResult Post(BAddress newBAddress)
        {
            _BAddressRepository.Register(newBAddress);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um BAddress existente
        /// </summary>
        /// <param name="id">ID do BAddress deletado</param>
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _BAddressRepository.Delete(id);
            return StatusCode(204);
        }


        /// <summary>
        /// Atualiza um BAddress existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="id">id do BAddress que será atualizado</param>
        /// <param name="BAddressRefresh">Objeto BAddressAtualizado com os novos dados</param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, BAddress BAddressRefresh)
        {
            BAddress SearchedBAddress = _BAddressRepository.ListId(id);

            if (SearchedBAddress == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Endereço não encontrado.",
                        erro = true
                    });
            }

            try
            {
                _BAddressRepository.Refresh(id, BAddressRefresh);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using PastelAPISolution.Application.Service.Inputs;
using PastelAPISolution.Application.Service.Interfaces;
using PastelAPISolution.Application.Service.Services;

namespace PastelAPISolution.Application.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Pedido")]
    public class PedidoController : Controller
    {

        private IPedidoApplicationService _pedidoApplicationService;


        public PedidoController(IPedidoApplicationService pedidoApplicationService)
        {
            _pedidoApplicationService = pedidoApplicationService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PedidoInput input)
        {
           var id = await _pedidoApplicationService.AddAsync(input);

            if (id <= 0)
                return BadRequest();

            return Created(Request.Path, input);
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pedidos = await _pedidoApplicationService.GetAsync();

            if (pedidos.Count() <= 0)
                return NotFound();

            return Ok(pedidos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var pedido = await _pedidoApplicationService.GetAsync(id);

            if(pedido == null)
                return NotFound();

            return Ok(pedido);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] PedidoInput input)
        {
            try
            {
               await _pedidoApplicationService.UpdateAsync(id, input);

                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _pedidoApplicationService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }



    }
}
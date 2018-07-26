using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PastelAPISolution.Application.Service.Inputs;
using PastelAPISolution.Application.Service.Interfaces;

namespace PastelAPISolution.Application.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Cliente")]
    public class ClienteController : Controller
    {
        private readonly IClienteApplicationService _clienteApplicationService;

        public ClienteController(IClienteApplicationService clienteApplicationService)
        {
            _clienteApplicationService = clienteApplicationService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClienteInput input)
        {
            var id = await _clienteApplicationService.AddAsync(input);

            if (id > 0)
                return Created(Request.Path, input);


            return BadRequest();

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clientes = await _clienteApplicationService.GetAsync();

            if (!clientes.Any())
                return NotFound();

            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var cliente = await _clienteApplicationService.GetAsync(id);

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ClienteInput input)
        {
            try
            {
                await _clienteApplicationService.UpdateAsync(id, input);

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
                await _clienteApplicationService.DeleteAsync(id);

                return Ok();

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }


    }
}
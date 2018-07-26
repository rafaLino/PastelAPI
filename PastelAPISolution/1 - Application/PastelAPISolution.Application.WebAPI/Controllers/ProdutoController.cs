using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PastelAPISolution.Application.Service.Inputs;
using PastelAPISolution.Application.Service.Interfaces;

namespace PastelAPISolution.Application.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Produto")]
    public class ProdutoController : Controller
    {

        private IProdutoApplicationService _produtoApplicationService;

        public ProdutoController(IProdutoApplicationService produtoApplicationService)
        {
            _produtoApplicationService = produtoApplicationService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProdutoInput input)
        {
            var id = await _produtoApplicationService.AddAsync(input);

            if (id <= 0)
                return BadRequest();

            return Created(Request.Path,input);

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var produtos = await _produtoApplicationService.GetAsync();
            
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var produto = await _produtoApplicationService.GetAsync(id);

            if (produto == null)
                return NotFound();

            return Ok(produto);
            
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody] ProdutoInput input)
        {
            try
            {
                await _produtoApplicationService.UpdateAsync(id, input);

                return Ok();
            }
            catch (Exception ex)
            {

              return  BadRequest(ex);
            }
            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _produtoApplicationService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
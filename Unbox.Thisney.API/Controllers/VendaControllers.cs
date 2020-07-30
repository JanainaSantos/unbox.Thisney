using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unbox.Thisney.API.Data;
using Unbox.Thisney.API.Model;

namespace Unbox.Thisney.API.Controllers
{
    [Route("api/venda")]
    [ApiController]
    public class VendaControllers : ControllerBase
    {
        public readonly DataContext _context;
        public VendaControllers(DataContext context)
        {
            this._context = context;
        }
        
        // GET api/values
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var vendas = await _context.Venda.ToListAsync();
                return Ok(vendas);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Venda model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Venda.Add(model);
                    await _context.SaveChangesAsync();
                    return Ok(model);
                }               
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }   

            return BadRequest();
        }
    }
}
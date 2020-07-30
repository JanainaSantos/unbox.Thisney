using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unbox.Thisney.API.Data;
using Unbox.Thisney.API.Model;

namespace Unbox.Thisney.API.Controllers
{
    [ApiController]
    [Route("api/evento")]
    public class EventoControllers : ControllerBase
    {
        public readonly DataContext _context;
        public EventoControllers(DataContext context)
        {
            this._context = context;
        }
        // GET api/values
        [HttpGet]
        [Route("")]
        public async Task<ActionResult> Get()
        {
            try
            {
                var eventos = await _context.Evento.ToListAsync();
                return Ok(eventos);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
        }

        // POST api/values
        [HttpPost]
        [Route("")]
        public async Task<ActionResult> Post([FromBody]Evento model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Evento.Add(model);
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
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unbox.Thisney.API.Data;
using Unbox.Thisney.API.Model;

namespace Unbox.Thisney.API.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteControllers : ControllerBase
    {
        public readonly DataContext _context;
        public ClienteControllers(DataContext context)
        {
            this._context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var clientes = await _context.Cliente.ToListAsync();
                return Ok(clientes);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Cliente model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Cliente.Add(model);
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
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Unbox.Thisney.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteControllers: ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                //var clientes = await _repository.GetAllCliente();
                //var results = _mapper.Map<IEnumerable<ClienteDto>>(clientes);
                return Ok();
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }            
        }
    }
}
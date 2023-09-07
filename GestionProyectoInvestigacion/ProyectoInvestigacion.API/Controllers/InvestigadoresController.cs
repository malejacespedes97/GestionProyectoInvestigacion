using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoInvestigacion.API.Data;
using ProyectoInvestigacion.Shared.Entities;

namespace ProyectoInvestigacion.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]// Habilita el endpoint del controlador
    public class InvestigadoresController : Controller
    {
        private readonly DataContext _context;

        public InvestigadoresController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]//get por lista
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Investigadores.ToListAsync());
        }

        [HttpGet("{id}")]//get por parametro
        public async Task<ActionResult> Get(int id)
        {
            var investigador = await _context.Investigadores.FirstOrDefaultAsync(x => x.Id == id);
            if (investigador == null)
            {
                return NotFound();
            }
            return Ok(investigador);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Investigador investigador) //siempre los post son iguales, solo cambia el nombre de la entidad
        {

            _context.Add(investigador);
            await _context.SaveChangesAsync();
            return Ok(investigador);
        }
    }
}

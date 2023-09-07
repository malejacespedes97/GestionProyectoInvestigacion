using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoInvestigacion.API.Data;
using ProyectoInvestigacion.Shared.Entities;

namespace ProyectoInvestigacion.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]// Habilita el endpoint del controlador
    public class ProyectosController : Controller
    {
        private readonly DataContext _context;

        public ProyectosController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]//get por lista
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Proyectos.ToListAsync());
        }

        [HttpGet("{id}")]//get por parametro
        public async Task<ActionResult> Get(int id)
        {
            var proyecto = await _context.Proyectos.FirstOrDefaultAsync(x => x.Id == id);
            if (proyecto == null)
            {
                return NotFound();
            }
            return Ok(proyecto);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Proyecto proyecto) //siempre los post son iguales, solo cambia el nombre de la entidad
        {
            _context.Add(proyecto);
            await _context.SaveChangesAsync();
            return Ok(proyecto);
        }
    }
}

using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Citas
{
    [ApiController]
    [Route("api/cita")]
     public class CitaCreateController : ControllerBase
    {
        private readonly ICitasRepository _citasRepository;
        public CitaCreateController(ICitasRepository citasRepository)
        {
            _citasRepository = citasRepository;
        }

        [HttpPost]
        public IActionResult CreateCita([FromBody] Cita cita)
        {
            _citasRepository.CreateCita(cita);
            return Ok();
        }
    }
}
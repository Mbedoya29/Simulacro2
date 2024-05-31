using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Especialidades
{
    [ApiController]
    [Route("api/especialidad")]
     public class EspecialidadCreateController : ControllerBase
    {
        private readonly IEspecialidadesRepository _especialidadesRepository;
        public EspecialidadCreateController(IEspecialidadesRepository especialidadesRepository)
        {
            _especialidadesRepository = especialidadesRepository;
        }

        [HttpPost]
        public IActionResult CreateEspecialidad([FromBody] Especialidad especialidad)
        {
            _especialidadesRepository.CreateEspecialidad(especialidad);
            return Ok();
        }
    }
}
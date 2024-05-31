using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Pacientes
{
    [ApiController]
    [Route("api/paciente")]
     public class PacienteCreateController : ControllerBase
    {
        private readonly IPacientesRepository _pacientesRepository;
        public PacienteCreateController(IPacientesRepository pacientesRepository)
        {
            _pacientesRepository = pacientesRepository;
        }
        [HttpPost]
        public IActionResult CreatePaciente([FromBody] Paciente paciente)
        {
            _pacientesRepository.CreatePaciente(paciente);
            return Ok();
        }
    }
}
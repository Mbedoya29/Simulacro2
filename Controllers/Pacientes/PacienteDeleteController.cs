using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Medicos
{
     public class PacienteDeleteController : ControllerBase
    {
        private readonly IPacientesRepository _pacientesRepository;
        public PacienteDeleteController(IPacientesRepository pacientesRepository)
        {
            _pacientesRepository = pacientesRepository;
        }
        [HttpDelete("api/paciente/{Id}")]
        public IActionResult RemovePaciente(int Id)
        {
            _pacientesRepository.RemovePaciente(Id);
            return Ok();
        }
    }
}
using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Pacientes
{
    [ApiController]
    public class PacienteUpdateController : ControllerBase
    {
        private readonly IPacientesRepository _pacientesRepository;
        public PacienteUpdateController(IPacientesRepository pacientesRepository)
        {
            _pacientesRepository = pacientesRepository;
        }  
        [HttpPut("api/paciente/{Id}")]
        public void UpdatePaciente(int Id, [FromBody] Paciente paciente) => _pacientesRepository.UpdatePaciente(Id, paciente);
    }
}
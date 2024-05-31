using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Pacientes
{
     public class PacientesController : ControllerBase
    {
        private readonly IPacientesRepository _pacientesRepository;
        public PacientesController(IPacientesRepository pacientesRepository)
        {
            _pacientesRepository = pacientesRepository;
        }
        [HttpGet]
        [Route("api/pacientes")]
        public IEnumerable<Paciente> GetPacientes()
        {
            return _pacientesRepository.GetAll();
        }
        [HttpGet]
        [Route("api/pacientes/{id}")]
        public Paciente Details(int id)
        {
            return _pacientesRepository.GetById(id);
        }
    }
}
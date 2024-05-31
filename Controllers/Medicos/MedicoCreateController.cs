using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Medicos
{
    [ApiController]
    [Route("api/medico")]
     public class MedicoCreateController : ControllerBase
    {
        private readonly IMedicosRepository _medicosRepository;
        public MedicoCreateController(IMedicosRepository medicosRepository)
        {
            _medicosRepository = medicosRepository;
        }
        [HttpPost]
        public IActionResult CreateMedico([FromBody] Medico medico)
        {
            _medicosRepository.CreateMedico(medico);
            return Ok();
        }
    }
}
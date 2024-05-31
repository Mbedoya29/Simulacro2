using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Medicos
{
     public class MedicoDeleteController : ControllerBase
    {
        private readonly IMedicosRepository _medicosRepository;
        public MedicoDeleteController(IMedicosRepository medicosRepository)
        {
            _medicosRepository = medicosRepository;
        }
        [HttpDelete("api/medico/{Id}")]
        public IActionResult RemoveMedico(int Id)
        {
            _medicosRepository.RemoveMedico(Id);
            return Ok();
        }
    }
}
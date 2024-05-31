using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Citas
{
     public class CitaRecoverController : ControllerBase
    {
        private readonly ICitasRepository _citasRepository;
        public CitaRecoverController(ICitasRepository citasRepository)
        {
            _citasRepository = citasRepository;
        }
        [HttpPut("api/RecoverCita/{Id}")]
        public IActionResult RecoverCita (int Id)
        {
            _citasRepository.RecoverCita(Id);
            return Ok();
        }
    }
}
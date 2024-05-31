using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Citas
{
     public class CitaDeleteController : ControllerBase
    {
        private readonly ICitasRepository _citasRepository;
        public CitaDeleteController(ICitasRepository citasRepository)
        {
            _citasRepository = citasRepository;
        }
        [HttpDelete("api/cita/{Id}")]
        public IActionResult RemoveCita (int Id)
        {
            _citasRepository.RemoveCita(Id);
            return Ok();
        }
    }
}
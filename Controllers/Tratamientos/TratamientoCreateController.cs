using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Tratamientos
{
    [ApiController]
    [Route("api/tratamiento")]
     public class TratamientoCreateController : ControllerBase
    {
        private readonly ITratamientosRepository _tratamientosRepository;
        public TratamientoCreateController(ITratamientosRepository tratamientosRepository)
        {
            _tratamientosRepository = tratamientosRepository;
        }
        [HttpPost]
        public IActionResult CreateTratamiento([FromBody] Tratamiento tratamiento)
        {
            _tratamientosRepository.CreateTratamiento(tratamiento);
            return Ok();
        }
    }
}
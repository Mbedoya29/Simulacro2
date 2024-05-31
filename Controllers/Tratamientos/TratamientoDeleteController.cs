using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Medicos
{
     public class TratamientoDeleteController : ControllerBase
    {
        private readonly ITratamientosRepository _tratamientosRepository;
        public TratamientoDeleteController(ITratamientosRepository tratamientosRepository)
        {
            _tratamientosRepository = tratamientosRepository;
        }
        [HttpDelete("api/tratamiento/{Id}")]
        public IActionResult RemoveTratamiento(int Id)
        {
            _tratamientosRepository.RemoveTratamiento(Id);
            return Ok();
        }
    }
}
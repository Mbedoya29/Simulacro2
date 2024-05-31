using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Tratamientos
{
    [ApiController]
    public class TratamientoUpdateController : ControllerBase
    {
        private readonly ITratamientosRepository _tratamientosRepository;
        public TratamientoUpdateController(ITratamientosRepository tratamientosRepository)
        {
            _tratamientosRepository = tratamientosRepository;
        }  
        [HttpPut("api/tratamiento/{Id}")]
        public void UpdateTratamiento(int Id, [FromBody] Tratamiento tratamiento) => _tratamientosRepository.UpdateTratamiento(Id, tratamiento);
    }
}
using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Especialidades
{
     public class EspecialidadDeleteController : ControllerBase
    {
        private readonly IEspecialidadesRepository _especialidadesRepository;
        public EspecialidadDeleteController(IEspecialidadesRepository especialidadesRepository)
        {
            _especialidadesRepository = especialidadesRepository;
        }
        [HttpDelete("api/especialidad/{Id}")]
        public IActionResult RemoveEspecialidad (int Id)
        {
            _especialidadesRepository.RemoveEspecialidad(Id);
            return Ok();
        }
    }
}
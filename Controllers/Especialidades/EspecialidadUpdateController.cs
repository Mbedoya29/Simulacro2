using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Especialidades
{
     public class EspecialidadUpdateController : ControllerBase
    {
        private readonly IEspecialidadesRepository _especialidadesRepository;
        public EspecialidadUpdateController(IEspecialidadesRepository especialidadesRepository)
        {
            _especialidadesRepository = especialidadesRepository;
        }

        [HttpPut("api/especialidad/{Id}")]
        public void UpdateEspecialidad(int Id, [FromBody] Especialidad especialidad) => _especialidadesRepository.UpdateEspecialidad(Id, especialidad);
    }
}
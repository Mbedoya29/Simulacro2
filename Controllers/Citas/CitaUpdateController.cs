using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Citas
{
     public class CitaUpdateController : ControllerBase
    {
        private readonly ICitasRepository _citasRepository;
        public CitaUpdateController(ICitasRepository citasRepository)
        {
            _citasRepository = citasRepository;
        }

        [HttpPut("api/cita/{Id}")]
        public void UpdateEspecialidad(int Id, [FromBody] Cita cita) => _citasRepository.UpdateCita(cita.Id,cita);

    }
}
using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Medicos
{
     public class MedicoUpdateController : ControllerBase
    {
        private readonly IMedicosRepository _medicosRepository;
        public MedicoUpdateController(IMedicosRepository medicosRepository)
        {
            _medicosRepository = medicosRepository;
        }
        [HttpPut("api/medico/{Id}")]
        public void UpdateMedico(int Id, [FromBody] Medico medico) => _medicosRepository.UpdateMedico(Id, medico);
    }
}
using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Medicos
{
     public class MedicosController : ControllerBase
    {
        private readonly IMedicosRepository _medicosRepository;
        public MedicosController(IMedicosRepository medicosRepository)
        {
            _medicosRepository = medicosRepository;
        }
        [HttpGet]
        [Route("api/medicos")]
        public IEnumerable<Medico> GetMedicos()
        {
            return _medicosRepository.GetAll();
        }
        [HttpGet]
        [Route("api/medicos/{id}")]
        public Medico Details(int id)
        {
            return _medicosRepository.GetById(id);
        }
    }
}
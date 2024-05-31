using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Especialidades
{
     public class EspecialidadesController : ControllerBase
    {
        private readonly IEspecialidadesRepository _especialidadesRepository;
        public EspecialidadesController(IEspecialidadesRepository especialidadesRepository)
        {
            _especialidadesRepository = especialidadesRepository;
        }
        [HttpGet]
        [Route("api/especialidades")]
        public IEnumerable<Especialidad> GetEspecialidades()
        {
            return _especialidadesRepository.GetAll();
        }
        [HttpGet]
        [Route("api/especialidades/{id}")]
        public Especialidad Details(int id)
        {
            return _especialidadesRepository.GetById(id);
        }
    }
}
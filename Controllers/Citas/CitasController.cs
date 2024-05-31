using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Citas
{
     public class CitasController : ControllerBase
    {
        private readonly ICitasRepository _citasRepository;
        public CitasController(ICitasRepository citasRepository)
        {
            _citasRepository = citasRepository;
        }
        [HttpGet]
        [Route("api/citas")]
        public IEnumerable<Cita> GetCitas()
        {
            return _citasRepository.GetAll();
        }
        [HttpGet]
        [Route("api/citas/{id}")]
        public Cita Details(int id)
        {
            return _citasRepository.GetById(id);
        }
    }
}
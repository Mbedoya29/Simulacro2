using Simulacro2.Models;
using Simulacro2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Simulacro2.Controllers.Tratamientos
{
     public class TratamientosController : ControllerBase
    {
        private readonly ITratamientosRepository _tratamientosRepository;
        public TratamientosController(ITratamientosRepository tratamientosRepository)
        {
            _tratamientosRepository = tratamientosRepository;
        }
        [HttpGet]
        [Route("api/tratamientos")]
        public IEnumerable<Tratamiento> GetTratamientos()
        {
            return _tratamientosRepository.GetAll();
        }
        [HttpGet]
        [Route("api/tratamientos/{id}")]
        public Tratamiento Details(int id)
        {
            return _tratamientosRepository.GetById(id);
        }
    }
}
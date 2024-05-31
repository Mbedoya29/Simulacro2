using Simulacro2.Data;
using Simulacro2.Models;

namespace Simulacro2.Services 
{
    public class EspecialidadesRepository : IEspecialidadesRepository
    {
        private readonly BaseContext _context;
        public EspecialidadesRepository (BaseContext context)
        {
            _context = context;
        }

        public void CreateEspecialidad (Especialidad especialidad)
        {
            _context.Especialidades.Add(especialidad);
            _context.SaveChanges();
        }
        public IEnumerable<Especialidad> GetAll()
        {
            return _context.Especialidades.ToList();
        }
        public Especialidad GetById (int id)
        {
            return _context.Especialidades.Find(id);
        }
        public void RemoveEspecialidad(int id)
        {
            var especialidad = _context.Especialidades.Find(id);
            especialidad.Estado = "Inactivo";
            _context.Especialidades.Update(especialidad);
            _context.SaveChanges();
        }
        public void UpdateEspecialidad (int id, Especialidad especialidad)
        {
            especialidad.Id = id;
            _context.Especialidades.Update(especialidad);
            _context.SaveChanges();
        }
    }
}
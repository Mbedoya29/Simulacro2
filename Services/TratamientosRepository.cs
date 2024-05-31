using Simulacro2.Data;
using Simulacro2.Models;

namespace Simulacro2.Services 
{
    public class TratamientosRepository : ITratamientosRepository
    {
        private readonly BaseContext _context;
        public TratamientosRepository(BaseContext context)
        {
            _context = context;
        }

        public void CreateTratamiento(Tratamiento tratamiento)
        {
            _context.Tratamientos.Add(tratamiento);
            _context.SaveChanges();
        }
        public IEnumerable<Tratamiento> GetAll()
        {
            return _context.Tratamientos.ToList();
        }
        public Tratamiento GetById(int id)
        {
            return _context.Tratamientos.Find(id);
        }
        public void RemoveTratamiento(int id)
        {
            var tratamiento = _context.Tratamientos.Find(id);
            tratamiento.Estado = "Inactivo";
            _context.Tratamientos.Update(tratamiento);
            _context.SaveChanges();
        }
        public void UpdateTratamiento(int id, Tratamiento tratamiento)
        {
            tratamiento.Id = id;
            _context.Tratamientos.Update(tratamiento);
            _context.SaveChanges();
        }
    }
}
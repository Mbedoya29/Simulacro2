using Simulacro2.Data;
using Simulacro2.Models;

namespace Simulacro2.Services 
{
    public class CitasRepository : ICitasRepository
    {
        private readonly BaseContext _context;
        public CitasRepository (BaseContext context)
        {
            _context = context;
        }

        public void CreateCita (Cita cita)
        {
            _context.Citas.Add(cita);
            _context.SaveChanges();
        }
        public IEnumerable<Cita> GetAll()
        {
            return _context.Citas.ToList();
        }
        public Cita GetById (int id)
        {
            return _context.Citas.Find(id);
        }
        public void RemoveCita(int id)
        {
            var cita = _context.Citas.Find(id);
            cita.Estado = "Inactivo";
            _context.Citas.Update(cita);
            _context.SaveChanges();
        }
        public void UpdateCita (int id, Cita cita)
        {
            _context.Citas.Update(cita);
            _context.SaveChanges();
        }
        public void RecoverCita (int id)
        {
            var recover = _context.Citas.Find(id);
            recover.Estado = "Activo";
            _context.Citas.Update(recover);
            _context.SaveChanges();
        }
    }
}
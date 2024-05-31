using Simulacro2.Data;
using Simulacro2.Models;

namespace Simulacro2.Services 
{
    public class PacientesRepository : IPacientesRepository
    {
        private readonly BaseContext _context;
        public PacientesRepository(BaseContext context)
        {
            _context = context;
        }

        public void CreatePaciente(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
        }
        public IEnumerable<Paciente> GetAll()
        {
            return _context.Pacientes.ToList();
        }
        public Paciente GetById(int id)
        {
            return _context.Pacientes.Find(id);
        }
        public void RemovePaciente(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            paciente.Estado = "Inactivo";
            _context.Pacientes.Update(paciente);
            _context.SaveChanges();
        }
        public void UpdatePaciente(int id, Paciente paciente)
        {
            paciente.Id = id;
            _context.Pacientes.Update(paciente);
            _context.SaveChanges();
        }
    }
}
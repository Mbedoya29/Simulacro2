using Simulacro2.Data;
using Simulacro2.Models;

namespace Simulacro2.Services 
{
    public class MedicosRepository : IMedicosRepository
    {
        private readonly BaseContext _context;
        public MedicosRepository(BaseContext context)
        {
            _context = context;
        }

        public void CreateMedico(Medico medico)
        {
            _context.Medicos.Add(medico);
            _context.SaveChanges();
        }
        public IEnumerable<Medico> GetAll()
        {
            return _context.Medicos.ToList();
        }
        public Medico GetById(int id)
        {
            return _context.Medicos.Find(id);
        }
        public void RemoveMedico(int id)
        {
            var medico = _context.Medicos.Find(id);
            medico.Estado = "Inactivo";
            _context.Medicos.Update(medico);
            _context.SaveChanges();
        }
        public void UpdateMedico(int id, Medico medico)
        {
            medico.Id = id;
            _context.Medicos.Update(medico);
            _context.SaveChanges();
        }
    }
}
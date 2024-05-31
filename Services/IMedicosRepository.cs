using Simulacro2.Models;

namespace Simulacro2.Services
{
    public interface IMedicosRepository
    {
        IEnumerable<Medico> GetAll();
        Medico GetById(int id);
        void CreateMedico(Medico medico);
        void RemoveMedico(int id);
        void UpdateMedico(int id, Medico medico);
    }
}
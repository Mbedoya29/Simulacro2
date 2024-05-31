using Simulacro2.Models;

namespace Simulacro2.Services
{
    public interface IPacientesRepository
    {
        IEnumerable<Paciente> GetAll();
        Paciente GetById(int id);
        void CreatePaciente (Paciente paciente);
        void RemovePaciente (int id);
        void UpdatePaciente(int id, Paciente paciente);
    }
}
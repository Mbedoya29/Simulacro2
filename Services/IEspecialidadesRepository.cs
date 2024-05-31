using Simulacro2.Models;

namespace Simulacro2.Services 
{
    public interface IEspecialidadesRepository 
    {
        IEnumerable<Especialidad> GetAll();
        Especialidad GetById (int id);
        void CreateEspecialidad (Especialidad especialidad);
        void RemoveEspecialidad (int id);
        void UpdateEspecialidad (int id, Especialidad especialidad);
    }
}
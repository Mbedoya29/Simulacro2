using Simulacro2.Models;

namespace Simulacro2.Services
{
    public interface ITratamientosRepository
    {
        IEnumerable<Tratamiento> GetAll();
        Tratamiento GetById(int id);
        void CreateTratamiento (Tratamiento tratamiento);
        void RemoveTratamiento (int id);
        void UpdateTratamiento(int id, Tratamiento tratamiento);
    }
}
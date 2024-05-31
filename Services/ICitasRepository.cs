using Simulacro2.Models;

namespace Simulacro2.Services 
{
    public interface ICitasRepository 
    {
        IEnumerable<Cita> GetAll();
        Cita GetById (int id);
        void CreateCita (Cita cita);
        void RemoveCita (int id);
        void UpdateCita (int id, Cita cita);
        void RecoverCita (int id);
    }
}
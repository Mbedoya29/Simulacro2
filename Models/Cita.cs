using System.Text.Json.Serialization;

namespace Simulacro2.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Estado { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }

        [JsonIgnore]
        public Medico? Medico { get; set; }
        
        [JsonIgnore]
        public Paciente? Paciente { get; set; }

        [JsonIgnore]
        public List<Tratamiento>? Tratamientos { get; set; }
    }
}
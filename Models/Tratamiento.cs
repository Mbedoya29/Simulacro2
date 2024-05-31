using System.Text.Json.Serialization;

namespace Simulacro2.Models
{
    public class Tratamiento
    {
        public int Id { get; set;}
        public string? Descripcion { get; set;}
        public string? Estado { get; set;}
        public int CitaId { get; set;}

        [JsonIgnore]
        public Cita? Cita { get; set; }
    }
}
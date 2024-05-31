using System.Text.Json.Serialization;

namespace Simulacro2.Models
{
    public class Medico
    {
        public int Id { get; set;}
        public string? NombreCompleto { get; set;}
        public string? Correo { get; set;}
        public string? Telefono { get; set;}
        public string? Estado { get; set;}
        public int EspecialidadId { get; set;}

        [JsonIgnore]
        public Especialidad? Especialidad { get; set;}
    }
}
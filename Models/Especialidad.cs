using System.Text.Json.Serialization;

namespace Simulacro2.Models
{
    public class Especialidad
    {
        public int Id { get; set;}
        public string? Nombre { get; set;}
        public string? Descripcion { get; set;}
        public string? Estado { get; set;}
    }
}
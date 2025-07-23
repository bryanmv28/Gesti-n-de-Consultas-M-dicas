using System;

namespace ClinicaMedica.Models
{
    public class PacienteModel
    {
        public int PacienteId { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
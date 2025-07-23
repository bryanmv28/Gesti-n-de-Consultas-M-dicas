using System;

namespace ClinicaMedica.Models
{
    public class CitaModel
    {
        public int CitaId { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public DateTime FechaCita { get; set; }
        public string Diagnostico { get; set; }
        public string Estado { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaClinicaWeb.Core.Models.Clinica;

namespace SistemaClinicaWeb.Core.Models.Persona
{
    public class Paciente : PersonaBase
    {
        [Required(ErrorMessage = "Este campo debe ser llenado obligatoriamente")]
        public int NumeroHistorialClinico { get; set; }
        [Required(ErrorMessage = "Este campo debe ser llenado obligatoriamente")]
        public int DNI { get; set; }
        public int MedicoId { get; set; }
        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }
        public int HabitacionId { get; set; }
        [ForeignKey("HabitacionId")]
        public Habitacion Habitacion { get; set; }
    }
}

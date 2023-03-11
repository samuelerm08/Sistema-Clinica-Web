using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinicaWeb.Core.Models.Persona
{
    public class Medico : PersonaBase
    {
        [Required(ErrorMessage = "Este campo debe ser llenado obligatoriamente")]
        public int NumeroMatricula { get; set; }
        [Required(ErrorMessage = "Este campo debe ser llenado obligatoriamente")]
        public string Especialidad { get; set; }
        public List<Paciente> Pacientes { get; set; }
    }
}

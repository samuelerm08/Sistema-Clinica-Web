using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SistemaClinicaWeb.Core.Models.Persona; 

namespace SistemaClinicaWeb.Core.Models.Clinica
{
    public enum Estado
    {
        Disponible, Ocupada
    }
    public class Habitacion
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo debe ser llenado obligatoriamente")]        
        public int Numero { get; set; }
        [Required(ErrorMessage = "Este campo debe ser llenado obligatoriamente")]
        public Estado Estado { get; set; }
        public List<Paciente> Paciente { get; set; }
    }
}

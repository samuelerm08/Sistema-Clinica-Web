using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinicaWeb.Core.Models.Persona
{
    public class PersonaBase
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo debe ser llenado obligatoriamente")]
        [Column(TypeName = "varchar(30)")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo debe ser llenado obligatoriamente")]
        [Column(TypeName = "varchar(30)")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Este campo debe ser llenado obligatoriamente")]
        public int Telefono { get; set; }
        [Required(ErrorMessage = "Este campo debe ser llenado obligatoriamente")]
        [Column(TypeName = "varchar(30)")]
        public string Domicilio { get; set; }
    }
}

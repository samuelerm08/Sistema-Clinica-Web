using Microsoft.EntityFrameworkCore;
using SistemaClinicaWeb.Core.Models.Persona;
using SistemaClinicaWeb.Core.Models.Clinica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SistemaClinicaWeb.Core.Data
{
    public class DbClinicaContext : IdentityDbContext
    {
        public DbClinicaContext(DbContextOptions<DbClinicaContext> options) : base(options) { }
        
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }        
    }
}

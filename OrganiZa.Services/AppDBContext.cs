using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OrganiZa.Models;
namespace OrganiZa.Services
{
    public class AppDBContext : DbContext
    {
        // Propiedades y métodos de la clase.
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<AdministradorModels> Administrador { get; set; }
        public DbSet<TutorModels> Tutor { get; set; }
        public DbSet<EscuelaModels> Escuela { get; set; }
        public DbSet<PagosModels> Pagos { get; set; }
        public DbSet<CalendarioModels> Calendario { get; set; }




    }

}


   


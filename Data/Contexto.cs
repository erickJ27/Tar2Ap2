using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Genero> Generos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8N0MTSG\SQLEXPRESS; Database =TestDb;Trusted_Connection =true");
        }
    }
    public class Genero
    {
        [Key]
        public int GeneroId { get; set; }
        public string Nombre { get; set; }
    }

}

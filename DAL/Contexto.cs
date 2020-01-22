using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tarea2.Entidades;

namespace Tarea2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Genero> Genero { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SBR4M50\SQLEXPRESS; Database =TestDb;Trusted_Connection =true");
        }
    }
    
}

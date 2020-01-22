using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea2.Entidades
{
    public class Genero
    {
        [Key]
        public int GeneroId { get; set; }
        public string Nombre { get; set; }
    }
}

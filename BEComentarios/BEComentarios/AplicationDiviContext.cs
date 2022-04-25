using BEComentarios.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEComentarios
{
    public class AplicationDiviContext : DbContext
    {

        public DbSet<Comentario> Comentario { get; set; }

        public AplicationDiviContext(DbContextOptions<AplicationDiviContext>options):base(options)
            
         {
         
        }

    }
}

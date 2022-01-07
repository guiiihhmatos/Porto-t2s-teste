using System;
using Microsoft.EntityFrameworkCore;

namespace PortoSP.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Conteiner> Conteiners { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
            
        }
    }
}
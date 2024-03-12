using ConexaoBancoDadosOracle.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBancoDadosOracle.Config
{
    internal class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
                Database.EnsureCreated();
        }

        public DbSet<USU_TTESTE> USU_TTESTE { get; set; }
    }
}

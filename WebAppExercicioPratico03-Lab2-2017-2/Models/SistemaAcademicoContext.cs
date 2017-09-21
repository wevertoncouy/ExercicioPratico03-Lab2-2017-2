using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppExercicioPratico03_Lab2_2017_2.Models
{
    public class SistemaAcademicoContext:DbContext
    {
        public SistemaAcademicoContext():base("DefaultConnection")
        {

        }
        public DbSet <Estudante> Estudante { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public System.Data.Entity.DbSet<WebAppExercicioPratico03_Lab2_2017_2.Models.NivelEnsino> NivelEnsinoes { get; set; }

        public System.Data.Entity.DbSet<WebAppExercicioPratico03_Lab2_2017_2.Models.Professor> Professors { get; set; }

        public System.Data.Entity.DbSet<WebAppExercicioPratico03_Lab2_2017_2.Models.Curso> Cursoes { get; set; }
    }
}
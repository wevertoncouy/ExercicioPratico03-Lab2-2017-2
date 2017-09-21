using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppExercicioPratico03_Lab2_2017_2.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nome { get; set; }
        public  int ProfessorId { get; set; }

        public List<Estudante> Estudantes { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppExercicioPratico03_Lab2_2017_2.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string ProfessorNome { get; set; }
        public string TipoProfessor { get; set; }
        public int NivelEnsinoId { get; set; }

        public List<Curso>Cursos{ get; set; }
    }
}
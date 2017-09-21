using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppExercicioPratico03_Lab2_2017_2.Models
{
    public class Estudante
    {
        [Key]
        public  int EstundateId { get; set; }
        public string EstusanteNome{ get; set; }
        public DateTime DataDeNascimento{ get; set; }
        public string Foto { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public int NivelEnsinoId{ get; set; }


        public Endereco Endereco { get; set; }
        public List<Curso>Cursos{get; set; }

    }
}
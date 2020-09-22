using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UNIVERSIDADEPADAWAN.Models;

namespace UNIVERSIDADEPADAWAN.Repository
{
    public static class Adiciona
    {
        public static List<Aluno> Aluno { get; set; }
        public static List<Curso> Curso { get; set; }
        public static List<Materia> Materia { get; set; }
        public static List<Notas> Notas { get; set; }

        public static void AdicionaAluno(Aluno aluno)
        {
            Aluno.Add(aluno);
        }

        public static void AdicionaCurso(Curso curso)
        {
            Curso.Add(curso);
        }

        public static void AdicionaMateria(Materia materia)
        {
            Materia.Add(materia);
        }

        public static void AdicionaNota(Notas nota)
        {
            Notas.Add(nota);
        }

    }
}

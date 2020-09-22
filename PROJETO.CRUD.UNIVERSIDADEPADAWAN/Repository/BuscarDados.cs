using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UNIVERSIDADEPADAWAN.Models;

namespace UNIVERSIDADEPADAWAN.Repository
{
    public static class BuscarDados
    {
        public static List<Aluno> Aluno { get; set; }
        public static List<Curso> Curso { get; set; }
        public static List<Materia> Materia { get; set; }
        public static List<Notas> Notas { get; set; }



        public static void MostraAluno(List<Aluno> aluno)
        {
            foreach(var p in aluno)
            {
                Console.WriteLine(p.Nome, p.Sobrenome, p.Cpf, p.Curso);
            }

        }

        public static void MostraCurso(List<Curso> curso)
        {
            foreach(var p in curso)
            {
                Console.WriteLine(p.NomeCurso, p.Situacao);
            }
        }

        public static void MostraCurso(List<Materia> materia)
        {
            foreach (var p in materia)
            {
                Console.WriteLine(p.Descricao, p.SituacaoMateria);
            }

        }

        public static void MostraNota(List<Notas> nota)
        {
            foreach (var p in nota)
            {
                Console.WriteLine(p.Nota);
            }
        }
    }
}

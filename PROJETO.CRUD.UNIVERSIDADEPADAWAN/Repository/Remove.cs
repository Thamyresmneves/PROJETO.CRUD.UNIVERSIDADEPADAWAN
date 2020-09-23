using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UNIVERSIDADEPADAWAN.Models;

namespace UNIVERSIDADEPADAWAN.Repository
{
    public class Remove
    {
        public static List<Aluno> Aluno { get; set; }
        public static List<Curso> Curso { get; set; }
        public static List<Materia> Materia { get; set; }
        public static List<Nota> Notas { get; set; }

        public void RemoveAluno(Aluno aluno)
        {           
            Aluno.Remove(aluno);                            
        }

        public void RemoveCurso(Curso curso)
        {        
            Curso.Remove(curso);          
        }

        public void RemoveCurso(Materia materia)
        {
            Materia.Remove(materia);          
        }

        public void RemoveNota(Nota nota)
        {           
            Notas.Remove(nota);         
        }
    }
}

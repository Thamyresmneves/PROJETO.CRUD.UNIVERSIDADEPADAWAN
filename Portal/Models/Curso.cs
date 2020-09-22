using System.Collections.Generic;


namespace Portal
{
    public class Curso
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }       
        public bool Situacao { get; set; }
        public List<Materia> Materias { get; set; }
    }
}

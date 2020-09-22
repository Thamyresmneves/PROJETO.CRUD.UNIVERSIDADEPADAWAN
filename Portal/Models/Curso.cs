using System.Collections.Generic;


namespace Portal
{
    public class Curso
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }       
        public string Situacao { get; set; }
        public List<Materia> Materias { get; set; }
    }
}

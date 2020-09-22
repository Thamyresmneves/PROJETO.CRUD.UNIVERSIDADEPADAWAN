using System.Collections.Generic;


namespace Portal
{
    public class Notas
    {
        public int Id { get; set; }        
        public string Nota { get; set; }
        public string Materia{ get; set; }
        public string Aluno { get; set; }

        //  public ICollection<Materia> Materia { get; set; } = new HashSet<Materia>();
        //  public ICollection<Aluno> Aluno { get; set; } = new HashSet<Aluno>();
    }
}

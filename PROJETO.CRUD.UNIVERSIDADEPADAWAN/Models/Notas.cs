using System.Collections.Generic;


namespace UNIVERSIDADEPADAWAN.Models
{
    public class Notas
    {
        public int Id { get; set; }
        public List<Aluno> Aluno { get; set; }
        public List<Materia> Materia { get; set; }
        public int Nota { get; set; }

    }
}

using System.Collections.Generic;

namespace ProjectSmartSchool2022.Models
{
    public class Professor
    {

        public Professor()
        {
        }
        public Professor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplina { get; set; }
    }
}
 
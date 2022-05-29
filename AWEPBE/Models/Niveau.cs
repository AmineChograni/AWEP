using System.Collections.Generic;

namespace AWEPBE.Models
{
    public class Niveau
    {
        protected int Id { get; set; }
        protected string Label { get; set; }
        protected ICollection<Filiere> Filieres { get; set; }
        protected ICollection<Coure> Coures { get; set; }
        protected ICollection<Evaluation> Evaluations { get; set; }
    }
}

using System.Collections.Generic;

namespace AWEPBE.Models
{
    public class Annee
    {
        protected int Id { get; set; }
        protected string Label { get; set; }
        protected ICollection<Evaluation> Evaluations { get; set; }
    }
}

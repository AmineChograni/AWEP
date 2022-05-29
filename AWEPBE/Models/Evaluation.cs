using System;
using System.Collections.Generic;

namespace AWEPBE.Models
{
    public class Evaluation
    {
        protected int Id { get; set; }
        protected string Label { get; set; }
        protected DateTime Date { get; set; }
        protected string Description { get; set; }
        protected EvaluationType TypeEvaluation { get; set; }
        protected int AnneeId { get; set; }
        protected Annee Annee { get; set; }
        protected ICollection<Note> Notes { get; set; }
    }
}

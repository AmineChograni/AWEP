using System.Collections.Generic;

namespace AWEPBE.Models
{
    public class Filiere
    {
        protected int Id { get; set; }
        protected string Label { get; set; }
        protected int AdminId { get; set; }
        protected Admin Admin { get; set; }
        protected int NiveauId { get; set; }
        protected Niveau Niveau { get; set; }
        protected int SecteurId { get; set; }
        protected Secteur Secteur { get; set; }
        protected ICollection<Group> Groups { get; set; }
        protected ICollection<Coure> Coures { get; set; }
        protected ICollection<Etudient> Etudients { get; set; }

    }
}

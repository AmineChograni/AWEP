using System.Collections.Generic;

namespace AWEPBE.Models
{
    public class Secteur
    {
        protected int Id { get; set; }
        protected string Label { get; set; }
        protected ICollection<Filiere> Filieres { get; set; }
    }
}

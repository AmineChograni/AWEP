namespace AWEPBE.Models
{
    public class Coure
    {
        protected int Id { get; set; }
        protected string Titre { get; set; }
        protected string CoureFile { get; set; }
        protected int FiliereId { get; set; }
        protected Filiere Filiere { get; set; }
        protected int AdminId { get; set; }
        protected Admin Admin { get; set; }
        protected int NiveauId { get; set; }
        protected Niveau Niveau { get; set; }


    }
}

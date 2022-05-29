namespace AWEPBE.Models
{
    public class Inscription
    {
        protected int Id { get; set; }
        protected string Nom { get; set; }
        protected string Prenom { get; set; }
        protected string Email { get; set; }
        protected string Telephone { get; set; }
        protected string NiveauScolaire { get; set; }
        protected string FilierSpecefier { get; set; }
        protected bool StatuDinscription { get; set; }
        protected int AdminId { get; set; }
        protected Admin Admin { get; set; }
    }
}

namespace AWEPBE.Models
{
    public class Admin
    {
        protected int Id { get; set; }
        protected string Nom { get; set; }
        protected string Prenom { get; set; }
        protected string Login { get; set; }
        protected string PasswordHash { get; set; }
        protected string Email { get; set; }
        protected string Telephone { get; set; }
        protected string Poste { get; set; }


    }
}

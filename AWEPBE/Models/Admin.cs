using Microsoft.AspNetCore.Identity;

namespace AWEPBE.Models
{
    public class Admin : IdentityUser
    {
        protected string Nom { get; set; }
        protected string Prenom { get; set; }
        protected string Login { get; set; }
        protected string Telephone { get; set; }
        protected string Poste { get; set; }


    }
}

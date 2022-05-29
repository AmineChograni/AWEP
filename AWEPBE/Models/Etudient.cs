using System;
using System.Collections.Generic;

namespace AWEPBE.Models
{
    public class Etudient
    {
        protected int Id { get; set; }
        protected string Nom { get; set; }
        protected string Prenom { get; set; }
        protected string NInscription { get; set; }
        protected string Image { get; set; }
        protected string UserName { get; set; }
        protected string PasswordHash { get; set; }
        protected string Adresse { get; set; }
        protected string Email { get; set; }
        protected bool Statu { get; set; }
        protected string Telephone { get; set; }
        protected string Remarque { get; set; }
        protected string NiveauScolaire { get; set; }
        protected DateTime DateInscription { get; set; }
        protected ICollection<Note> Notes { get; set; }
        protected ICollection<Reclamation> Reclamations { get; set; }
        protected int FilierId { get; set; }
        protected Filiere Filiere { get; set; }
        protected int AdminId { get; set; }
        protected Admin Admin { get; set; }

    }
}

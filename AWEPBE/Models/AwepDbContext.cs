using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AWEPBE.Models
{
    public class AwepDbContext : IdentityDbContext
    {
        public AwepDbContext(DbContextOptions<AwepDbContext> options)
            : base(options) { }

        public DbSet<Actualite> Actualites { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Annee> Annees { get; set; }
        public DbSet<Certification> Certifications { get; set; }

        public DbSet<Coure> Coures { get; set; }
        public DbSet<EmploiDuTemps> EmploiDuTemps { get; set; }
        public DbSet<Etudient> Etudients { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Filiere> Filieres { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Mail> Mails { get; set; }
        public DbSet<Niveau> Niveaus { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Reclamation> Reclamations { get; set; }
        public DbSet<Secteur> Secteurs { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
